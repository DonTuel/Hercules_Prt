using System;
using System.Collections.Generic;

using System.IO;
using CustomStructures;
using CustomExtensions;

namespace Hercules_Prt
{
    class PrtRTF
    {
        private static String _rtfHdr = "{\\rtf1\\ansi\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Courier;}}\r\n";
        private static String _rtfDoc = "\\landscape\\paperh12240\\paperw20160\\margl720\\margr720\\margt720\\margb720\\pard\\f0\\fs22 ";
        private static String _rtfEnd = "}\r\n";
        private static String _rtfPage = "\\page ";
        private static String _rtfNL = "\\par\r\n";

        public XMLHerculesPrt XMLHerculesPrt { get; private set; } = null;

        public PrtRTF(XMLHerculesPrt cfg)
        {
            XMLHerculesPrt = cfg;
        }

        public void ProcessReport(List<List<String>> document, List<CustomFieldValue> bojFieldValues, List<CustomFieldValue> eojFieldValues)
        {
            String docPath = XMLHerculesPrt.RTFOutput.OutputDir;
            String docName = XMLHerculesPrt.RTFOutput.OutputFileTemplate;

            if (!(bojFieldValues == null))
            {
                foreach (var item in bojFieldValues)
                {
                    if (docName.Contains(item.fieldName))
                    {
                        docName = docName.Replace(item.fieldName, item.fieldValue);
                    }
                }
            }

            if (!(eojFieldValues == null))
            {
                foreach (var item in eojFieldValues)
                {
                    if (docName.Contains(item.fieldName))
                    {
                        docName = docName.Replace(item.fieldName, item.fieldValue);
                    }
                }
            }

            if (!(docName.EndsWith(".rtf")))
            {
                docName += ".rtf";
            }

            if (!(docPath.EndsWith("\\")))
            {
                docPath += "\\";
            }

            docPath += docName;

            StreamWriter reportOut = new StreamWriter(docPath, false);
            reportOut.WriteLine(_rtfHdr);
            reportOut.WriteLine(_rtfDoc);

            Int32 iStart = 0;
            if (!(XMLHerculesPrt.CustomizationData.BOJCustomization.BOJPrintBanners.ToBool()))
            { iStart++; }
            Int32 iEnd = document.Count;
            if (!(XMLHerculesPrt.CustomizationData.EOJCustomization.EOJPrintBanners.ToBool()))
            { iEnd--; }

            for (int i = iStart; i < iEnd; i++)
            {
                foreach (var item in document[i])
                {
                    reportOut.WriteLine(item + _rtfNL);
                }
                reportOut.WriteLine(_rtfPage);
            }

            reportOut.WriteLine(_rtfEnd);

            reportOut.Flush();
            reportOut.Close();
            reportOut.Dispose();

        }
    }
}
