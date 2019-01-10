using System;
using System.Collections.Generic;
using System.Drawing;

namespace steg_v2
{
    class Controller
    {
        public StegImg inputImg { get; set; }

        public bool Extract()
        {
            bool success = true;

            //CHANGE INTO ONE METHOD
            inputImg.imgToLSBArr();
            inputImg.bitArrToBytes();
            inputImg.createFile();

            return success;
        }
        public bool Hide()
        {
            bool success = true;

            //CHANGE INTO ONE METHOD
            inputImg.imgToLSBArr();
            inputImg.matchBitArray();
            inputImg.createFile();

            return success;
        }
    }
}
