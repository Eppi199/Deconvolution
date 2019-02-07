using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace FFT.Bitmapp
{
    class ByteBitmap
    {
        public const byte MaxColor = 255;

        public const byte BlackColor = 0;
        public const byte WhiteColor = 255;

        private readonly byte[] bitmap;

        public byte this[int x, int y]
        {
            get { return bitmap[y * width + x]; }
            set { bitmap[y * width + x] = value; }
        }

        public byte[] Data
        {
            get { return bitmap; }
        }

        private readonly int width;
        public int Width
        {
            get { return width; }
        }

        private readonly int height;
        public int Height
        {
            get { return height; }
        }

        public ByteBitmap(int width, int height)
        {
            this.width = width;
            this.height = height;
            bitmap = new byte[this.width * this.height];
        }

        public ByteBitmap(int width, int height, byte defaultValue)
        {
            this.width = width;
            this.height = height;
            bitmap = new byte[this.width * this.height];
            if (defaultValue == 0)
                return;

            for (int i = 0; i < bitmap.Length; ++i)
                bitmap[i] = defaultValue;
        }

        public ByteBitmap(int width, int height, byte[] data)
        {
            if (data.Length != (width * height))
                throw new Exception("Incorrect data size in ByteBitmap initialization.");

            this.width = width;
            this.height = height;
            this.bitmap = (byte[])data.Clone();
        }

        public ByteBitmap(ByteBitmap bitmap)
        {
            this.width = bitmap.width;
            this.height = bitmap.height;
            this.bitmap = (byte[])bitmap.bitmap.Clone();
        }

        public virtual Object Clone()
        {
            return new ByteBitmap(this); ;
        }
    }
}
