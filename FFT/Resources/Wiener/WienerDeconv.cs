using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging;
using AForge.Math;
using System.IO;
using System.Drawing.Imaging;
using FFT.Bitmapp;

namespace FFT
{
    class WienerDeconv
    {

        // Out of Focus Blur....................................
        public static Complex[,] GetFocusBlurComplexImage(Size OutImageSize, float Radius, float Edge)
        {
            Complex[,] lRes = null;

            int size = Convert.ToInt32(2 * Radius + 1);

            Complex[,] FocusBlur = new Complex[size * 2 + 1, size * 2 + 1];
            //
            //-1/(2 * aSigma ^ 2);
            double larg = 1 / (Math.PI * Radius * Radius);
            float lSumm = 0;
            for (int ly = 0; ly <  size; ly++)
                for (int lx = 0; lx < size; lx++)
                {
                    float xdiff = (float)lx - size/2;
                    float ydiff = (float)ly - size/2;
                    float dist = (float)Math.Sqrt((xdiff * xdiff) + (ydiff * ydiff));
                    if (dist <= Radius)
                    {
                        double sig = (Radius * Edge) / 100;
                        float lVal = (float)Math.Exp(-Math.Pow(((dist - Radius) / sig), 2) / 2);
                        lSumm += lVal;
                        FocusBlur[lx, ly] = new Complex(lVal, 0);
                    }
                }

            //normalize by summ
            for (int ly = 0; ly < size; ly++)
                for (int lx = 0; lx < size; lx++)
                {
                    FocusBlur[lx, ly] = new Complex(FocusBlur[lx, ly].Re / lSumm, 0);
                }

            //fit for res
            lRes = new Complex[OutImageSize.Width, OutImageSize.Height];
            int lNewShiftX = (OutImageSize.Width - size);
            int lNewShiftY = (OutImageSize.Height - size);
            for (int ly = 0; ly < size; ly++)
                for (int lx = 0; lx < size; lx++)
                {
                    lRes[lx ,ly] = FocusBlur[lx, ly];
                }

            return lRes;
        }

        // Gaussian Blur....................................
        public static Complex[,] GetGaussianComplexImage(Size OutImageSize, int HalfWindow, float aSigma)
        {
            Complex[,] lRes = null;

            int lMinHalf = Math.Min(OutImageSize.Width, OutImageSize.Height) / 2;
            HalfWindow = Math.Min(HalfWindow, lMinHalf);

            Complex[,] Gausian = new Complex[2 * HalfWindow + 15, 2 * HalfWindow + 1];
            int lHeight = 2 * HalfWindow + 1;
            int lWidth = 2 * HalfWindow + 1;
            float lCenterX = (float)HalfWindow;
            float lCenterY = (float)HalfWindow;
            //
            //-1/(2 * aSigma ^ 2);
            float larg = -1 / (2 * aSigma * aSigma);
            float lSumm = 0;
            for (int ly = 0; ly < lHeight; ly++)
                for (int lx = 0; lx < lWidth; lx++)
                {
                    float xdiff = (float)lx - lCenterX;
                    float ydiff = (float)ly - lCenterY;
                    float lVal = (float)(Math.Exp(larg * ((xdiff * xdiff) + (ydiff * ydiff))));
                    lSumm += lVal;
                    Gausian[lx, ly] = new Complex(lVal, 0);
                }

            //normalize by summ
            for (int ly = 0; ly < lHeight; ly++)
                for (int lx = 0; lx < lWidth; lx++)
                {
                    Gausian[lx, ly] = new Complex(Gausian[lx, ly].Re / lSumm, 0);
                }

            //fit for res
            lRes = new Complex[OutImageSize.Width, OutImageSize.Height];
            int lNewShiftX = (OutImageSize.Width - lWidth) / 2;
            int lNewShiftY = (OutImageSize.Height - lHeight) / 2;
            for (int ly = 0; ly < lHeight; ly++)
                for (int lx = 0; lx < lWidth; lx++)
                {
                    lRes[lx, ly] = Gausian[lx, ly];
                }

            return lRes;
        }

        // Moution Blur....................................
        public static Complex[,] GetMotionComplexImage(Size OutImageSize, int Angle, float Length)
        {
            Complex[,] lRes = null;

            int size = Convert.ToInt32(Length + 1);

            Complex[,] Motion = new Complex[size * 2 + 1, size * 2 + 1];

            double motionAngleRad = Math.PI * Angle / 180;
            float lSumm = 0;
                for (int lx = 0; lx < size; lx++)
                {
                    float xdiff = (float)(lx - size/2);
                    if (xdiff <= Length)
                    {
                        float lVal = (float)(1 / Length);
                        lSumm += lVal;
                        Motion[lx, 0] = new Complex(lVal, 0);
                    }
                }

            //normalize by summ
            for (int ly = 0; ly < size; ly++)
                for (int lx = 0; lx < size; lx++)
                {
                    Motion[lx, ly] = new Complex(Motion[lx, ly].Re / lSumm, 0);
                }

            //fit for res
            lRes = new Complex[OutImageSize.Width, OutImageSize.Height];
            int lNewShiftX = (OutImageSize.Width - size);
            int lNewShiftY = (OutImageSize.Height - size);
            for (int ly = 0; ly < size; ly++)
                for (int lx = 0; lx < size; lx++)
                {
                    lRes[lx, ly] = Motion[lx, ly];
                }

            return lRes;
        }

        // <summary>
        // Function of Wiener Filter
        // </summary>
        //<param name="Fx">Current Image in the frequency domain</param> 
        //<param name="Hx">Current convolve fuction in in the frequency domain</param> 
        //<param name="Nsr">Noise to Signal level. Can be calculated by the empiric functions</param> 
        // <returns></returns>          
        public static Complex[,] WienerFilter(Complex[,] Fx, Complex[,] Hx, float Nsr)
        {
            int w = Fx.GetLength(0);
            int h = Fx.GetLength(1);
            Complex[,] lRes = new Complex[w, h];
            double lMinHIm = 0.00000000001f;
            double lNormVal = w * h;

            //proceed
            for (int ly = 0; ly < h; ly++)
                for (int lx = 0; lx < w; lx++)
                {
                    Complex lH = new Complex(Hx[lx, ly]);
                    Complex lF = new Complex(Fx[lx, ly]);

                    //normalization for forward translation because of current realization of FFT
                    lH *= lNormVal;
                    lF *= lNormVal;

                    //nomalize lH
                    if (Math.Abs(lH.Im) < lMinHIm)
                        lH.Im = 0;

                    //calculate denom
                    double denom = lH.Re * lH.Re + lH.Im * lH.Im;
                    denom = denom + Nsr;

                    //
                    if (denom < lMinHIm)
                        denom = Math.Sign(denom) * lMinHIm;

                    //calculate G
                    //conj it

                    //lH.Im = -lH.Im;
                    //lH.Re = Math.Abs(lH.Re);

                    //devide by the denom
                    lH.Re = lH.Re / denom;
                    lH.Im = lH.Im / denom;

                    //calculate result
                    Complex lVal = lH * lF;
                    //normalization for backward translation because of current realization of FFT
                    lVal /= lNormVal;
                    lRes[lx, ly] = lVal;
                }

            return lRes;
        }

        // Out of Focus Blur....................................
        public static ByteBitmap WienerFilterFromOutOfFocus(ByteBitmap aBitmap, float Sigma, float Nsr, float Edge)
        {

            //make fft from abitmap
            Point lStart;
            ByteBitmap lLoc = FFTHelpers.FitByteBitmapForFFT2D(aBitmap, 10, out lStart, 255);
            Complex[,] lFx = FFTHelpers.ByteBitmapToComplex(lLoc);
            FourierTransform.FFT2(lFx, FourierTransform.Direction.Forward);

            //make Out of Focus Blur FFT
            Complex[,] lHx = GetFocusBlurComplexImage(new Size(lLoc.Width, lLoc.Height), Sigma, Edge);
            FourierTransform.FFT2(lHx, FourierTransform.Direction.Forward);

            //make wiener
            Complex[,] lWR = WienerFilter(lFx, lHx, Nsr);

            //backward result
            FourierTransform.FFT2(lWR, FourierTransform.Direction.Backward);

            //convert to bytebitmap
            ByteBitmap lRes = FFTHelpers.ComplexToByteBitmap(lWR);
            lRes = FFTHelpers.GetFittedByteBitmapFromFFT2D(lRes, lStart, new Size(aBitmap.Width, aBitmap.Height));
            return lRes;
        }

        // Gaussian Blur....................................
        public static ByteBitmap WienerFilterFromGaussian(ByteBitmap aBitmap, int HW, float Sigma, float Nsr)
        {

            //make fft from abitmap
            Point lStart;
            ByteBitmap lLoc = FFTHelpers.FitByteBitmapForFFT2D(aBitmap, 10, out lStart, 255);
            Complex[,] lFx = FFTHelpers.ByteBitmapToComplex(lLoc);
            FourierTransform.FFT2(lFx, FourierTransform.Direction.Forward);

            //make gauss FFT
            Complex[,] lHx = GetGaussianComplexImage(new Size(lLoc.Width, lLoc.Height), HW, Sigma);
            FourierTransform.FFT2(lHx, FourierTransform.Direction.Forward);

            //make wiener
            Complex[,] lWR = WienerFilter(lFx, lHx, Nsr);

            //backward result
            FourierTransform.FFT2(lWR, FourierTransform.Direction.Backward);

            //convert to bytebitmap
            ByteBitmap lRes = FFTHelpers.ComplexToByteBitmap(lWR);
            lRes = FFTHelpers.GetFittedByteBitmapFromFFT2D(lRes, lStart, new Size(aBitmap.Width, aBitmap.Height));
            return lRes;
        }

        // Moution Blur....................................
        public static ByteBitmap WienerFilterFromMoution(ByteBitmap aBitmap, float Length, int Angle, float Nsr)
        {

            //make fft from abitmap
            Point lStart;
            ByteBitmap lLoc = FFTHelpers.FitByteBitmapForFFT2D(aBitmap, 10, out lStart, 255);
            Complex[,] lFx = FFTHelpers.ByteBitmapToComplex(lLoc);
            FourierTransform.FFT2(lFx, FourierTransform.Direction.Forward);

            //make moution FFT
            Complex[,] lHx = GetMotionComplexImage(new Size(lLoc.Width, lLoc.Height), Angle, Length);
            FourierTransform.FFT2(lHx, FourierTransform.Direction.Forward);

            //make wiener
            Complex[,] lWR = WienerFilter(lFx, lHx, Nsr);

            //backward result
            FourierTransform.FFT2(lWR, FourierTransform.Direction.Backward);

            //convert to bytebitmap
            ByteBitmap lRes = FFTHelpers.ComplexToByteBitmap(lWR);
            lRes = FFTHelpers.GetFittedByteBitmapFromFFT2D(lRes, lStart, new Size(aBitmap.Width, aBitmap.Height));
            return lRes;
        }
    }
}
