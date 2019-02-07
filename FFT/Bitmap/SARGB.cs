using System;
using System.Runtime.InteropServices;

namespace FFT.Bitmapp
{
    /// <summary>
    /// ARGB Structure to access A,R,G,B value of single ARGB pixel
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    struct SARGB
    {
        #region Data section
        [FieldOffset(0)]
        public Int32 Value;
        [FieldOffset(3)]
        public byte A;
        [FieldOffset(2)]
        public byte R;
        [FieldOffset(1)]
        public byte G;
        [FieldOffset(0)]
        public byte B;
        #endregion

        /// <summary>
        ///Makes fast convertation from ARGB32 to byte A8R8G8B8 values
        /// </summary>
        ///<param name="aValue">ARGB32 value</param>
        public SARGB(Int32 aValue, byte R, byte G, byte B)
        {
            this.A = 3; this.R = 2; this.G = 1;  this.B = 0; this.Value = aValue;
        }
    }
		
}
