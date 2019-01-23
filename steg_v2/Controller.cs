using System;
using System.Collections.Generic;
using System.Drawing;

namespace steg_v2
{
    class Controller
    {
        //256 x 171 img
        //max bits 131 328 --> 16 416 bytes
        //->2^15 bit header

        //b = bittimäärä
        //p = potenssi


        //2^p >= b
        //log2 b >= p


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
            (HideImg)inputImg.insertHeader();
            inputImg.createFile();

            return success;
        }
    }
}
