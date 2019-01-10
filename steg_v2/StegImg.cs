using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace steg_v2
{
    abstract class StegImg
    {
        public Bitmap image { get; set; }
        public String outputpath { get; set; }
        protected BitArray lsbarr;
        protected byte[] bytearr;

        public abstract void createFile();
        public virtual void fileToBytes(String path)
        {
            //Method only used in HideImg.
        }
        public virtual void matchBitArray()
        {

        }
        protected bool getLSB(byte b)
        {
            //Gets LSB of a byte
            bool lsb = true;
            if (b % 2 == 0)
            {
                lsb = false;
            }
            
            return lsb;
        }
        protected bool[] getPixelColorLSB(int x, int y)
        {
            //Returns chosen pixel's colors' LSB
            //Goes through all colors in order
            bool[] rgblsb = { false, true, false };

            rgblsb[0] = getLSB(image.GetPixel(x, y).R);
            rgblsb[1] = getLSB(image.GetPixel(x, y).G);
            rgblsb[2] = getLSB(image.GetPixel(x, y).B);

            return rgblsb;
        }
        private void reverseBitArray(BitArray array)
        {
            //With the courtesy of Tim Lloyd
            int length = array.Length;
            int mid = (length / 2);

            for (int i = 0; i < mid; i++)
            {
                bool bit = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = bit;
            }
        }
        public void imgToLSBArr()
        {
            //Creates a BitArray of image's pixels' LSB's
            bool[] rgblsb = new bool[3];
            int i = 0;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    rgblsb = getPixelColorLSB(x, y);

                    lsbarr[i] = rgblsb[0];
                    lsbarr[i + 1] = rgblsb[1];
                    lsbarr[i + 2] = rgblsb[2];
                    i = i + 3;
                }
            }
        }
        public void bitArrToBytes()
        {
            BitArray bits = new BitArray(8);    //Bits of one byte
            int bitscount = 0;
            int bytecount = 0;
            for(int i = 0; i < lsbarr.Length; i++)
            {
                bits[bitscount] = lsbarr[i];
                bitscount++;
                if (bitscount >= 8)
                {
                    //reverseBitArray(bits);
                    bits.CopyTo(bytearr, bytecount);
                    bytecount++;
                    bitscount = 0;
                }
            }
            Console.WriteLine(bytearr[0]);
        }
    }
}
