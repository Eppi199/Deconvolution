using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace FFT.Bitmapp
{
    class BitmapHelpers
    {
        static public System.Drawing.Bitmap ByteBitmapToBitmap(ByteBitmap aBmp)
        {
            System.Drawing.Bitmap lBmp = new System.Drawing.Bitmap(aBmp.Width, aBmp.Height, PixelFormat.Format32bppPArgb);

            BitmapData lBmpDta = lBmp.LockBits(new Rectangle(0, 0, lBmp.Width, lBmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            try
            {
                IntPtr lScan0 = lBmpDta.Scan0;
                Int32[] lRow = new Int32[lBmp.Width];
                SARGB lRGB = new SARGB(3,2,1,0);
                lRGB.A = 0xff; lRGB.R = 0xff;
                lRGB.G = 0xFF; lRGB.B = 0xff;
                for (int ly = 0; ly < lBmp.Height; ly++)
                {
                    for (int lx = 0; lx < lBmp.Width; lx++)
                    {
                        lRGB.R = lRGB.B = lRGB.G = aBmp[lx, ly];
                        lRow[lx] = lRGB.Value;
                    }
                    //copy to row
                    Marshal.Copy(lRow, 0, new IntPtr(lScan0.ToInt64() + (sizeof(Int32) * ly * lBmp.Width)), lRow.Length);

                }
            }
            finally
            {
                //unlock
                lBmp.UnlockBits(lBmpDta);
            }

            return lBmp;
        }

        static public System.Drawing.Bitmap ByteBitmapToBitmap(ByteBitmap aBmpR, ByteBitmap aBmpG, ByteBitmap aBmpB)
        {
            Bitmap lBmp = new System.Drawing.Bitmap(aBmpR.Width, aBmpR.Height, PixelFormat.Format32bppPArgb);

            BitmapData lBmpDta = lBmp.LockBits(new Rectangle(0, 0, lBmp.Width, lBmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            try
            {
                IntPtr lScan0 = lBmpDta.Scan0;
                Int32[] lRow = new Int32[lBmp.Width];
                SARGB lRGB = new SARGB(3, 2, 1, 0);
                lRGB.A = 0xff; lRGB.R = 0xff;
                lRGB.G = 0xFF; lRGB.B = 0xff;
                for (int ly = 0; ly < lBmp.Height; ly++)
                {
                    for (int lx = 0; lx < lBmp.Width; lx++)
                    {
                        lRGB.R = aBmpR[lx, ly];
                        lRGB.G = aBmpG[lx, ly];
                        lRGB.B = aBmpB[lx, ly];
                        lRow[lx] = lRGB.Value;
                    }
                    //copy to row
                    Marshal.Copy(lRow, 0, new IntPtr(lScan0.ToInt64() + (sizeof(Int32) * ly * lBmp.Width)), lRow.Length);

                }
            }
            finally
            {
                //unlock
                lBmp.UnlockBits(lBmpDta);
            }

            return lBmp;
        }

        static public ByteBitmap BitmapToByteBitmap(Bitmap aBmp, int R = 30, int G = 59, int B = 11)
        {
            if (null == aBmp) throw new ArgumentNullException("aBmp is null");

            int lWidth = aBmp.Width;
            int lHeight = aBmp.Height;
            ByteBitmap lRes = new ByteBitmap(lWidth, lHeight);

            System.Drawing.Bitmap lBmp = new System.Drawing.Bitmap(lWidth, lHeight, PixelFormat.Format32bppPArgb);
            try
            {
                //draw it
                Graphics lgrf = Graphics.FromImage(lBmp);
                lgrf.DrawImage(aBmp, 0, 0, lBmp.Width, lBmp.Height);
                lgrf.Dispose();
                //lock bitmap bits for reading
                BitmapData lBmpDta = lBmp.LockBits(new Rectangle(0, 0, lBmp.Width, lBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
                try
                {
                    IntPtr lScan0 = lBmpDta.Scan0;
                    Int32[] lRow = new Int32[lBmp.Width];
                    SARGB lRGB = new SARGB(3, 2, 1, 0);
                    var sum = R + G + B;
                    for (int ly = 0; ly < lBmp.Height; ly++)
                    {
                        //get the bitmap row
                        Marshal.Copy(new IntPtr(lScan0.ToInt64() + (sizeof(Int32) * ly * lBmp.Width)), lRow, 0, lRow.Length);
                        //copy to
                        for (int lx = 0; lx < lBmp.Width; lx++)
                        {
                            lRGB.Value = lRow[lx];
                            //http://en.wikipedia.org/wiki/Grayscale
                            //30% of the red value, 59% of the green value, and 11% of the blue value
                            //m_img[lx, ly] = (byte)(Math.Min((30 * lRGB.R + 59 * lRGB.G + 11 * lRGB.B) / 100, 255));
                            //simple
                            var avg = (lRGB.R*R + lRGB.G*G + lRGB.B*B)/sum;
                            lRes[lx, ly] = (byte) Math.Min(avg, 255f);
                        }
                    }
                }
                finally
                {
                    //unlock
                    lBmp.UnlockBits(lBmpDta);
                }
            }
            finally
            {
                //delete
                lBmp.Dispose();
            }

            return lRes;
        }  
    }
}
