using System;
using System.Collections.Generic;
using System.Text;
using FFT.Bitmapp;
using System.Drawing;
using AForge.Math;

namespace FFT
{
    class FFTHelpers
    {
        public static int AdditionToPowerOfTwo(int N)
        {
            int lLog = (int)Math.Round(Math.Log(N, 2));
            int lVal = (int)Math.Round(Math.Pow(2, lLog));
            //is power of two
            if (lVal == N)
                return 0;
            //is lower then lval
            if (N < lVal)
                return (lVal - N);

            //is higher then lval
            lVal = (int)Math.Round(Math.Pow(2, lLog + 1));
            return (lVal - N);
        }

        public static ByteBitmap FitByteBitmapForFFT2D(ByteBitmap aBitmap, int Shift, out Point StartPoint, byte DefVal)
        {
            StartPoint = new Point(0, 0);
            ByteBitmap lRes = null;
            //calculate new 
            int lNewWidth = aBitmap.Width ;
            int lNewHeight = aBitmap.Height ;
            lNewWidth += AdditionToPowerOfTwo(lNewWidth);
            lNewHeight += AdditionToPowerOfTwo(lNewHeight);
            int lNewShiftX = (lNewWidth - aBitmap.Width) ;
            int lNewShiftY = (lNewHeight - aBitmap.Height) ;


            if (0 != DefVal)
                lRes = new ByteBitmap(lNewWidth, lNewHeight, DefVal);
            else
                lRes = new ByteBitmap(lNewWidth, lNewHeight);

            for (int ly = 0; ly < aBitmap.Height; ly++)
                for (int lx = 0; lx < aBitmap.Width; lx++)
                    lRes[lx + lNewShiftX, ly + lNewShiftY] = aBitmap[lx, ly];
            StartPoint.X = 0;
            StartPoint.Y = 0;

            return lRes;
        }

        public static ByteBitmap GetFittedByteBitmapFromFFT2D(ByteBitmap aBitmap, Point StartPoint, Size ImageSize)
        {
            ByteBitmap lRes = new ByteBitmap(ImageSize.Width, ImageSize.Height);
            for (int ly = 0; ly < ImageSize.Height; ly++)
                for (int lx = 0; lx < ImageSize.Width; lx++)
                    lRes[lx, ly] = aBitmap[lx + StartPoint.X, ly + StartPoint.Y];
            return lRes;
        }

        public static Complex[,] ByteBitmapToComplex(ByteBitmap aBitmap)
        {
            Complex[,] lRes = new Complex[aBitmap.Width, aBitmap.Height];

            for (int ly = 0; ly < aBitmap.Height; ly++)
                for (int lx = 0; lx < aBitmap.Width; lx++)
                    lRes[lx, ly] = new Complex(aBitmap[lx, ly], 0);
            return lRes;
        }


        public static ByteBitmap ComplexToByteBitmap(Complex[,] aBitmap)
        {
            int w = aBitmap.GetLength(0);
            int h = aBitmap.GetLength(1);
            ByteBitmap lRes = new ByteBitmap(w, h);
            for (int ly = 0; ly < lRes.Height; ly++)
                for (int lx = 0; lx < lRes.Width; lx++)
                {
                    Complex lTmp = aBitmap[lx, ly];
                    float lVal = (int)Math.Round(Math.Sqrt(lTmp.Re * lTmp.Re + lTmp.Im * lTmp.Im));
                    lRes[lx, ly] = (byte)Math.Min(lVal, 255);
                }

            return lRes;
        }

        /*
        public static ByteBitmap ComplexToByteBitmapOnlyReal(Complex[,] aBitmap)
        {
            int w = aBitmap.GetLength(0);
            int h = aBitmap.GetLength(1);
            ByteBitmap lRes = new ByteBitmap(w, h);
            for (int ly = 0; ly < lRes.Height; ly++)
                for (int lx = 0; lx < lRes.Width; lx++)
                {
                    Complex lTmp = aBitmap[lx, ly];
                    int lVal = (int)Math.Round(lTmp.Re);
                    lVal = Math.Min(Math.Max(lVal, 0), 255);
                    lRes[lx, ly] = (byte)lVal;
                }

            return lRes;
        } */
    }
}
