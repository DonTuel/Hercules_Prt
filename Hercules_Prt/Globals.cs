using System;
using System.Text;
using System.Windows.Forms;

namespace Hercules_Prt
{
    class Globals
    {
        #region " Global Variables "
        //public String SourceIP;
        //public Int32 SourcePort; 
        //public String HerculesIP; 
        //public Int32 HerculesPort; 
        //public String DestinationFile; 
        //public String[] DestinationFilePicks; 
        //public Int32 MaxConnections;
        //public Int32 BufferSize;
        //public String DestinationType; 
        //public Boolean UseLPDProtocols; 
        //public Boolean ConnectAtStart; 

        //public Boolean VerboseLogging; 
        //public Boolean DumpPackets; 
        //public Boolean DisplayStatistics; 
        //public Boolean ProtocolLogging; 

        //public Int32 MainLeft; 
        //public Int32 MainTop; 
        //public Int32 MainHeight; 
        //public Int32 MainWidth;
        //public String MainState;

        // If any of the above are changed then this variable is set to true
        // public Boolean GlobalsChanged;

        //public String MailID; 

        public StringBuilder DisplayText = null;

        public Int32 TransmissionsReceived = 0;
        public Int32 TransmissionsPassed = 0;
        public Int32 TransmissionsFailed = 0;

        //public AppInfo AppInfo;

        //private Mutex sMutex;
        private Boolean bMutexOwned = false;

        public static Byte[]
        ascii_to_ebcdic = {
         /*         x0    x1    x2    x3    x4    x5    x6    x7    x8    x9    xA    xB    xC    xD    xE    xF */
         /* 0x */ 0x00, 0x01, 0x02, 0x03, 0x37, 0x2D, 0x2E, 0x2F, 0x16, 0x05, 0x25, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
         /* 1x */ 0x10, 0x11, 0x12, 0x13, 0x3C, 0x3D, 0x32, 0x26, 0x18, 0x19, 0x1A, 0x27, 0x22, 0x1D, 0x35, 0x1F,
         /* 2x */ 0x40, 0x5A, 0x7F, 0x7B, 0x5B, 0x6C, 0x50, 0x7D, 0x4D, 0x5D, 0x5C, 0x4E, 0x6B, 0x60, 0x4B, 0x61,
         /* 3x */ 0xF0, 0xF1, 0xF2, 0xF3, 0xF4, 0xF5, 0xF6, 0xF7, 0xF8, 0xF9, 0x7A, 0x5E, 0x4C, 0x7E, 0x6E, 0x6F,
         /* 4x */ 0x7C, 0xC1, 0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xD1, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6,
         /* 5x */ 0xD7, 0xD8, 0xD9, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xAD, 0xE0, 0xBD, 0x5F, 0x6D,
         /* 6x */ 0x79, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96,
         /* 7x */ 0x97, 0x98, 0x99, 0xA2, 0xA3, 0xA4, 0xA5, 0xA6, 0xA7, 0xA8, 0xA9, 0xC0, 0x6A, 0xD0, 0xA1, 0x07,
         /* 8x */ 0x68, 0xDC, 0x51, 0x42, 0x43, 0x44, 0x47, 0x48, 0x52, 0x53, 0x54, 0x57, 0x56, 0x58, 0x63, 0x67,
         /* 9x */ 0x71, 0x9C, 0x9E, 0xCB, 0xCC, 0xCD, 0xDB, 0xDD, 0xDF, 0xEC, 0xFC, 0xB0, 0xB1, 0xB2, 0xB3, 0xB4,
         /* Ax */ 0x45, 0x55, 0xCE, 0xDE, 0x49, 0x69, 0x04, 0x06, 0xAB, 0x08, 0xBA, 0xB8, 0xB7, 0xAA, 0x8A, 0x8B,
         /* Bx */ 0x09, 0x0A, 0x14, 0xBB, 0x15, 0xB5, 0xB6, 0x17, 0x1B, 0xB9, 0x1C, 0x1E, 0xBC, 0x20, 0xBE, 0xBF,
         /* Cx */ 0x21, 0x23, 0x24, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x30, 0x31, 0xCA, 0x33, 0x34, 0x36, 0x38, 0xCF,
         /* Dx */ 0x39, 0x3A, 0x3B, 0x3E, 0x41, 0x46, 0x4A, 0x4F, 0x59, 0x62, 0xDA, 0x64, 0x65, 0x66, 0x70, 0x72,
         /* Ex */ 0x73, 0xE1, 0x74, 0x75, 0x76, 0x77, 0x78, 0x80, 0x8C, 0x8D, 0x8E, 0xEB, 0x8F, 0xED, 0xEE, 0xEF,
         /* Fx */ 0x90, 0x9A, 0x9B, 0x9D, 0x9F, 0xA0, 0xAC, 0xAE, 0xAF, 0xFD, 0xFE, 0xFB, 0x3F, 0xEA, 0xFA, 0xFF
         };     /*  x0    x1    x2    x3    x4    x5    x6    x7    x8    x9    xA    xB    xC    xD    xE    xF */

        public static Byte[]
        ebcdic_to_ascii = {
         /*         x0    x1    x2    x3    x4    x5    x6    x7    x8    x9    xA    xB    xC    xD    xE    xF */
         /* 0x */ 0x00, 0x01, 0x02, 0x03, 0xA6, 0x09, 0xA7, 0x7F, 0xA9, 0xB0, 0xB1, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
         /* 1x */ 0x10, 0x11, 0x12, 0x13, 0xB2, 0x0A, 0x08, 0xB7, 0x18, 0x19, 0x1A, 0xB8, 0xBA, 0x1D, 0xBB, 0x1F,
         /* 2x */ 0xBD, 0xC0, 0x1C, 0xC1, 0xC2, 0x0A, 0x17, 0x1B, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0x05, 0x06, 0x07,
         /* 3x */ 0xC8, 0xC9, 0x16, 0xCB, 0xCC, 0x1E, 0xCD, 0x04, 0xCE, 0xD0, 0xD1, 0xD2, 0x14, 0x15, 0xD3, 0xFC,
         /* 4x */ 0x20, 0xD4, 0x83, 0x84, 0x85, 0xA0, 0xD5, 0x86, 0x87, 0xA4, 0xD6, 0x2E, 0x3C, 0x28, 0x2B, 0xD7,
         /* 5x */ 0x26, 0x82, 0x88, 0x89, 0x8A, 0xA1, 0x8C, 0x8B, 0x8D, 0xD8, 0x21, 0x24, 0x2A, 0x29, 0x3B, 0x5E,
         /* 6x */ 0x2D, 0x2F, 0xD9, 0x8E, 0xDB, 0xDC, 0xDD, 0x8F, 0x80, 0xA5, 0x7C, 0x2C, 0x25, 0x5F, 0x3E, 0x3F,
         /* 7x */ 0xDE, 0x90, 0xDF, 0xE0, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0x60, 0x3A, 0x23, 0x40, 0x27, 0x3D, 0x22,
         /* 8x */ 0xE7, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0xAE, 0xAF, 0xE8, 0xE9, 0xEA, 0xEC,
         /* 9x */ 0xF0, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72, 0xF1, 0xF2, 0x91, 0xF3, 0x92, 0xF4,
         /* Ax */ 0xF5, 0x7E, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A, 0xAD, 0xA8, 0xF6, 0x5B, 0xF7, 0xF8,
         /* Bx */ 0x9B, 0x9C, 0x9D, 0x9E, 0x9F, 0xB5, 0xB6, 0xAC, 0xAB, 0xB9, 0xAA, 0xB3, 0xBC, 0x5D, 0xBE, 0xBF,
         /* Cx */ 0x7B, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0xCA, 0x93, 0x94, 0x95, 0xA2, 0xCF,
         /* Dx */ 0x7D, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52, 0xDA, 0x96, 0x81, 0x97, 0xA3, 0x98,
         /* Ex */ 0x5C, 0xE1, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A, 0xFD, 0xEB, 0x99, 0xED, 0xEE, 0xEF,
         /* Fx */ 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0xFE, 0xFB, 0x9A, 0xF9, 0xFA, 0xFF
         };     /*  x0    x1    x2    x3    x4    x5    x6    x7    x8    x9    xA    xB    xC    xD    xE    xF */
        #endregion

        public void LimitSingleInstance(ref String name)
        {
            //    sMutex = new Mutex(true, name, out bMutexOwned);
            bMutexOwned = !bMutexOwned;
        }

        public Boolean IsAnotherInstanceRunning()
        {
            return bMutexOwned;
        }

        public Char[] ByteArrayToCharArray(Byte[] b)
        {
            return Encoding.Default.GetChars(b);
        }

        public String StringArrayToDottedString(String[] str, Char dot = '.')
        {
            String outStr = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    outStr += str[i] + dot;
                }
            }

            return outStr.TrimEnd(dot);
        }

        public Boolean FillListView(ListView lv, String[] cols)
        {
            try
            {
                int n;

                ListViewItem item1 = new ListViewItem(cols[0], 0);

                for (n = 1; n < cols.Length; n++)
                {
                    if (n < lv.Columns.Count)
                    {
                        item1.SubItems.Add(cols[n]);
                    }
                }

                lv.Items.Add(item1);

                return true;
            }
            catch (Exception ex)
            {
                if (ex.HResult != 94)
                {
                    MessageBox.Show("Error: " + ex.HResult + "\n" + ex.Message);
                }
                return false;
            }
        }

        public String GetEnvironmentVariable(String envVar)
        {
            String str = envVar.ToUpper();

            if (str.StartsWith("%"))
            {
                str = str.Substring(1, str.Length - 2);
            }

            return Environment.GetEnvironmentVariable(str).ToUpper();
        }

        public String StandardizeFileName(String inFileName)
        {
            Char[] splitStrs = "\\?=+%&*~".ToCharArray();
            String tempName = inFileName.Replace(":", ".");
            tempName = tempName.Replace("//", "/");

            foreach (Char ch in splitStrs)
            {
                tempName = tempName.Replace(ch.ToString() + ch.ToString(), ch.ToString());
                tempName = tempName.Replace("/" + ch, "/");
                tempName = tempName.Replace(ch + "/", "/");
                tempName = tempName.Replace("." + ch, ".");
                tempName = tempName.Replace(ch + ".", ".");
            }

            //'   http://www.mamma.com/result.php?type=web&q=LPD+LPR+%22abc%22
            //'   http://www.mobilehandsetdesignline.com/encyclopedia/defineterm.jhtml?term=**RANDOM**
            //'   http://www.ex.biwa.ne.jp/~kuri65536/streao2/linux-psc1210.html

            string[] subParts = tempName.Split(splitStrs);

            return StringArrayToDottedString(subParts);

        }

        public String Hex_Dump_Asis(Byte[] buf, Int32 buflen, Int32 width)
        {
            String retStr = "";
            String retSStr = "";

            String retCStr = "  ";
            int k = buflen;
            int j;

            retStr = retStr + "{ Offset }";

            for (int i = 0; i < width; i++)
            {
                retStr = retStr + " " + i.ToString("X2");
            }
            retStr = retStr + " |";
            for (int i = 0; i < width; i++)
            {
                if ((i % 8) == 7)
                {
                    retStr = retStr + "+";
                }
                else
                {
                    retStr = retStr + ".";
                }
            }
            retStr = retStr + "|";
            retStr = retStr + Environment.NewLine;

            retSStr = retSStr + "{ 000000 }";

            int wHex = width - 1;

            for (j = 0; j < k; j++)
            {
                retSStr = retSStr + " " + buf[j].ToString("X2");
                Char c = ByteToChar(buf[j]);
                retCStr = retCStr + c.ToString();
                //retCStr = retCStr + "\\'" + c.ToString("x2");
                if ((j & wHex) == wHex)
                {
                    retStr = retStr + retSStr + retCStr + Environment.NewLine;
                    if (j < (k - 1))
                    {
                        retSStr = "{ " + (j + 1).ToString("X6") + " }";
                        retCStr = "  ";
                    }
                    else
                    {
                        retSStr = "";
                        retCStr = "";
                    }
                }
            }
            j--;
            j = j & wHex;
             if (j > 0)
            {
                for (int jj = j; jj < wHex; jj++)
                {
                    retSStr = retSStr + "   ";
                }
            }
            if (!((retSStr == "") && (retCStr == "")))
            {
                retStr = retStr + retSStr + retCStr + Environment.NewLine;
            }

            retStr = retStr + Environment.NewLine;

            return retStr;
        }

        public String Hex_Dump_EBCDIC(Byte[] buf, Int32 buflen, Int32 width)
        {
            String retStr = "";
            String retSStr = "";
            Byte[] EBCDICdata = new Byte[buflen];

            String retCStr = "  ";
            int k = buflen;
            int j;

            retStr = retStr + "{ Offset }";

            for (int i = 0; i < width; i++)
            {
                retStr = retStr + " " + i.ToString("X2");
            }
            retStr = retStr + " |";
            for (int i = 0; i < width; i++)
            {
                if ((i % 8) == 7)
                {
                    retStr = retStr + "+";
                }
                else
                {
                    retStr = retStr + ".";
                }
            }
            retStr = retStr + "|";
            retStr = retStr + Environment.NewLine;

            retSStr = retSStr + "{ 000000 }";
            EBCDIC_to_asciiz(ref EBCDICdata, buflen, buf, 0, buflen);

            int wHex = width - 1;

            for (j = 0; j < k; j++)
            {
                retSStr = retSStr + " " + buf[j].ToString("X2");
                Char c = ByteToChar(EBCDICdata[j]);
                retCStr = retCStr + c.ToString();
                //retCStr = retCStr + "\\'" + c.ToString("x2");
                if ((j & wHex) == wHex)
                {
                    retStr = retStr + retSStr + retCStr + Environment.NewLine;
                    if (j < (k - 1))
                    {
                        retSStr = "{ " + (j + 1).ToString("X6") + " }";
                        retCStr = "  ";
                    }
                    else
                    {
                        retSStr = "";
                        retCStr = "";
                    }
                }
            }
            j--;
            j = j & wHex;
            if (j > 0)
            {
                for (int jj = j; jj < wHex; jj++)
                {
                    retSStr = retSStr + "   ";
                }
            }
            if (!((retSStr == "") && (retCStr == "")))
            {
                retStr = retStr + retSStr + retCStr + Environment.NewLine;
            }

            retStr = retStr + Environment.NewLine;

            return retStr;
        }

        public String ByteBufferToString(Byte[] buf, Int32 buflen)
        {
            String retCStr = "";

            for (int i = 0; i < buflen; i++)
            {
                Char c = ByteToChar(buf[i]);
                retCStr = retCStr + c.ToString();
            }

            return retCStr;
        }

        #region "Convert ASCIIZ to EBCDIC"
        /*-------------------------------------------------------------------*/
        /* Subroutine to convert an ASCIIZ byte array to an EBCDIC byte      */
        /* array. Returns the length of the EBCDIC array.                     */
        /*-------------------------------------------------------------------*/
        public int asciiz_to_EBCDIC(ref Byte[] dest, int destlen, Byte[] src, int srcoffset, int srclen)
        {
            int idx;                    /* Result length             */

            //            set_codepage(NULL);

            for (idx = 0; idx < srclen && idx < destlen - 1; idx++)
            { dest[idx] = host_to_guest(src[srcoffset + idx]); }

            return idx;

        } /* end function asciiz_to_EBCDIC */

        /*-------------------------------------------------------------------*/
        /* Subroutine to convert an ASCIIZ string to an EBCDIC string.       */
        /* Removes trailing blanks and adds a terminating null.              */
        /* Returns the length of the EBCDIC string excluding terminating null*/
        /*-------------------------------------------------------------------*/
        public int make_EBCDIC(ref Byte[] dest, int destlen, Byte[] src, int srcoffset, int srclen)
        {
            int idx;                    /* Result length             */

            //            set_codepage(NULL);

            for (idx = 0; idx < srclen && idx < destlen - 1; idx++)
                dest[idx] = host_to_guest(src[srcoffset + idx]);
            while (idx > 0 && dest[idx - 1] == host_to_guest((Byte)' ')) idx--;
            dest[idx] = 0x00;

            return idx;

        } /* end function make_asciiz */
        #endregion

        #region "Convert EBCDIC to ASCIIZ"
        /*-------------------------------------------------------------------*/
        /* Subroutine to convert an EBCDIC byte array to an ASCIIZ byte      */
        /* array. Returns the length of the ASCII array.                     */
        /*-------------------------------------------------------------------*/
        public int EBCDIC_to_asciiz(ref Byte[] dest, int destlen, Byte[] src, int srcoffset, int srclen)
        {
            int idx;                    /* Result length             */

            //            set_codepage(NULL);

            for (idx = 0; idx < srclen && idx < destlen; idx++)
            { dest[idx] = guest_to_host(src[srcoffset + idx]); }

            return idx;

        } /* end function EBCDIC_to_asciiz */

        /*-------------------------------------------------------------------*/
        /* Subroutine to convert an EBCDIC string to an ASCIIZ string.       */
        /* Removes trailing blanks and adds a terminating null.              */
        /* Returns the length of the ASCII string excluding terminating null */
        /*-------------------------------------------------------------------*/
        public int make_asciiz(ref Byte[] dest, int destlen, Byte[] src, int srcoffset, int srclen)
        {
            int idx;                    /* Result length             */

            //            set_codepage(NULL);

            for (idx = 0; idx < srclen && idx < destlen - 1; idx++)
                dest[idx] = guest_to_host(src[srcoffset + idx]);
            while (idx > 0 && dest[idx - 1] == ' ') idx--;
            dest[idx] = 0x00;

            return idx;

        } /* end function make_asciiz */
        #endregion

        #region "Use guest host page for EBCDIC and ASCII conversion"
        public static Byte guest_to_host(Byte chr)
        {
            return ebcdic_to_ascii[chr];
            //            return codepage_conv->g2h[chr];
        }
        public static Byte host_to_guest(Byte chr)
        {
            return ascii_to_ebcdic[chr];
            //            return codepage_conv->g2h[chr];
        }
        #endregion

        public Char ByteToChar(Byte byt)
    {
        if ((byt > 0x1f) && (byt < 0xff)) { return (Char)byt; }
        return '.';
    }
    }
}
