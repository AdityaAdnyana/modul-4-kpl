using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_103082400005
{
    internal class KodeBuah
    {

        public enum NamaBuah {
            Apel,       //0
            Aprikot,    //1
            Alpukat,    //2
            Pisang,     //3
            Paprika,    //4
            Blackberry, //5
            Ceri,       //6
            Kelapa,     //7
            Jagung,     //8
            Kurma,      //9
            Durian,     //10
            Anggur,     //11
            Melon,      //12
            Semangka    //13
        }

        private static readonly String[] kodeBuah =
            [
            "A00", //0
            "B00", //1
            "C00", //2
            "D00", //3
            "E00", //4
            "F00", //5
            "H00", //6
            "I00", //7
            "J00", //8
            "K00", //9
            "L00", //10
            "M00", //11
            "N00", //12
            "O00"  //13
            ];


        public static String GetKodeBuah(NamaBuah buah)
        {
            return kodeBuah[(int)buah];
        }
    }
}
