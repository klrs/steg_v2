using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace steg_v2
{
    class HideImg : StegImg
    {
        private Bitmap outputimg;
        private byte[] inputfile;   //Input file in bytes
        private BitArray ifilebits;

        public HideImg(String ipath)
        {
            image = new Bitmap(@ipath);
            int imgcolorcount = image.Height * image.Width * 3;
            lsbarr = new BitArray(imgcolorcount);
            bytearr = new byte[imgcolorcount / 8];
            outputimg = new Bitmap(image);
        }
        override public void createFile()
        {
            outputimg.Save(@outputpath);
            //System.IO.File.WriteAllBytes(outputpath, bytearr);
        }
        override public void fileToBytes(String path)
        {
            inputfile = File.ReadAllBytes(@path);
            bytesToBits();
        }
        private void bytesToBits()
        {
            ifilebits = new BitArray(inputfile);
            foreach(bool b in ifilebits)
            {
                Console.Write(b);
            }
            //Console.WriteLine(ifilebits.Count);
        }
        override public void matchBitArray()
        {
            for (int i = 0; i < ifilebits.Length; i++)
            {
                if (ifilebits[i] != lsbarr[i])
                    lsbarr[i] = ifilebits[i];
            }
            this.setPixels();
        }
        private void setPixels()
        {
            byte[] argb = new byte[4];
            int count = 0;
            for(int y = 0; y < image.Height; y++)
            {
                for(int x = 0; x < image.Width; x++)
                {
                    argb[0] = image.GetPixel(x, y).A;
                    argb[1] = image.GetPixel(x, y).R;
                    argb[2] = image.GetPixel(x, y).G;
                    argb[3] = image.GetPixel(x, y).B;

                    outputimg.SetPixel(x, y, changeLSB(ref argb, ref count));
                }
            }
        }
        private Color changeLSB(ref byte[] argb, ref int count)
        {
            //Changes LSB of a byte according to input file's bitarray
            //returns new pixel's color
            Color pixelcolor = new Color();
            for(int i = 1; i < argb.Length; i++)
            {
                //Console.WriteLine(count);
                if(count < ifilebits.Count)
                {
                    if (ifilebits[count] != getLSB(argb[i]))
                    {
                        argb[i] = Convert.ToByte(argb[i] ^ 1);
                    }
                    count++;
                }
            }
            pixelcolor = Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);
            return pixelcolor;
        }
        public void insertHeader()
        {
            double a = image.Height * image.Width * 3;
            double exponents = Math.Log(a, 2);
            Console.WriteLine(exponents);
        }
    }
}
