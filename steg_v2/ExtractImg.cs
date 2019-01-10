using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;

namespace steg_v2
{
    class ExtractImg : StegImg
    {
        public ExtractImg(String ipath)
        {
            image = new Bitmap(@ipath);
            int imgcolorcount = image.Height * image.Width * 3;
            lsbarr = new BitArray(imgcolorcount);
            bytearr = new byte[imgcolorcount / 8];
        }
        override public void createFile()
        {
            System.IO.File.WriteAllBytes(outputpath, bytearr);
            //System.IO.File.WriteAllText(outputpath, bytearr);
            //Console.WriteLine(System.Text.Encoding.ASCII.GetString(bytearr));
            //using (System.IO.FileStream fs = System.IO.File.Create(outputpath))
            //{
            //    //Console.Write("df");
            //    fs.Write(bytearr, 0, bytearr.Length);
            //}
        }
    }
}
