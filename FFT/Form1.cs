using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge;
using AForge.Math;
using AForge.Imaging.Filters;
using FFT.Bitmapp;
using FFT;


namespace FFT
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK) 
                return;

            var size = 512;
            pbSource.Image = new Bitmap(Bitmap.FromFile(ofd.FileName), 512, 512);
        //    Bitmap image = new Bitmap(pbSource.Image);
        //    var bmp8bpp = Grayscale.CommonAlgorithms.BT709.Apply(image);
            pbResult.Image = new Bitmap(Bitmap.FromFile(ofd.FileName), pbResult.Width, pbResult.Height); 
        }



        private void btFFTNormal_Click(object sender, EventArgs v)
        {
            Bitmap image = new Bitmap(pbSource.Image);
            var bmp8bpp = Grayscale.CommonAlgorithms.BT709.Apply(image);


            AForge.Imaging.ComplexImage cimage = AForge.Imaging.ComplexImage.FromBitmap(bmp8bpp);

            cimage.ForwardFourierTransform();

            System.Drawing.Bitmap img = cimage.ToBitmap();

            pbFourierMag.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFourierMag.Image = img;
        }

        private void btFFTDeconv_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pbResult.Image);
            var bmp8bpp = Grayscale.CommonAlgorithms.BT709.Apply(image);

            AForge.Imaging.ComplexImage cimage = AForge.Imaging.ComplexImage.FromBitmap(bmp8bpp);
         // int height = cimage.Data.GetLength(0);
         // int width = cimage.Data.GetLength(1);

            cimage.ForwardFourierTransform();

            /* for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cimage.Data[y, x].Re = cimage.Data[y, x].Phase;
                }
            } */

            Bitmap fourierImage = cimage.ToBitmap();
            pbFourierPhase.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFourierPhase.Image = fourierImage;            
        }

        // Out of Focus Blur....................................
        private void btDeconvolution_Click(object sender, EventArgs e)
        {
            float Edge = (float)EdgeValue.Value;
            float Nsr = (float)SmoothBlur.Value;
            float Radius = (float)RadiusBlur.Value;
            pbResult.Image = DeconvolutionOutOfFocus((Bitmap)pbSource.Image, Nsr, Radius, Edge);
        }

        Bitmap DeconvolutionOutOfFocus(Bitmap source, float Nsr, float Radius, float Edge)
        {
            var R = BitmapHelpers.BitmapToByteBitmap(source, 1, 0, 0);
            var G = BitmapHelpers.BitmapToByteBitmap(source, 0, 1, 0);
            var B = BitmapHelpers.BitmapToByteBitmap(source, 0, 0, 1);
            R = WienerDeconv.WienerFilterFromOutOfFocus(R, Radius, Nsr, Edge);
            G = WienerDeconv.WienerFilterFromOutOfFocus(G, Radius, Nsr, Edge);
            B = WienerDeconv.WienerFilterFromOutOfFocus(B, Radius, Nsr, Edge);
            return BitmapHelpers.ByteBitmapToBitmap(R, G, B);
        }

        private void SmoothValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Gaussian Blur....................................
        private void btDeconvolutionGauss_Click(object sender, EventArgs e)
        {
            float Nsr = (float)SmoothGaussian.Value;
            float sigma = (float)RadiusGaussian.Value;
            int HW = (int)HWvalue.Value;
            pbResult.Image = DeconvolutionGaussian((Bitmap)pbSource.Image, HW, Nsr, sigma);
        }
        Bitmap DeconvolutionGaussian(Bitmap source,int HW, float Nsr, float sigma)
        {
            var R = BitmapHelpers.BitmapToByteBitmap(source, 1, 0, 0);
            var G = BitmapHelpers.BitmapToByteBitmap(source, 0, 1, 0);
            var B = BitmapHelpers.BitmapToByteBitmap(source, 0, 0, 1);
            R = WienerDeconv.WienerFilterFromGaussian(R, HW, sigma, Nsr);
            G = WienerDeconv.WienerFilterFromGaussian(G, HW, sigma, Nsr);
            B = WienerDeconv.WienerFilterFromGaussian(B, HW, sigma, Nsr);
            return BitmapHelpers.ByteBitmapToBitmap(R, G, B);
        }

        // Moution Blur....................................
        private void btDeconvolutionMoution_Click(object sender, EventArgs e)
        {
            float Nsr = (float)SmoothMoution.Value;
            float Length = (float)LengthMoution.Value;
            int Angle = (int)AngleMoution.Value;
            pbResult.Image = DeconvolutionMoution((Bitmap)pbSource.Image, Length, Angle, Nsr);
        }
        Bitmap DeconvolutionMoution(Bitmap source, float Length, int Angle, float Nsr)
        {
            var R = BitmapHelpers.BitmapToByteBitmap(source, 1, 0, 0);
            var G = BitmapHelpers.BitmapToByteBitmap(source, 0, 1, 0);
            var B = BitmapHelpers.BitmapToByteBitmap(source, 0, 0, 1);
            R = WienerDeconv.WienerFilterFromMoution(R, Length, Angle,  Nsr);
            G = WienerDeconv.WienerFilterFromMoution(G, Length, Angle, Nsr);
            B = WienerDeconv.WienerFilterFromMoution(B, Length, Angle, Nsr);
            return BitmapHelpers.ByteBitmapToBitmap(R, G, B);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pbResult.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pbResult.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}