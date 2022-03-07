using System;
using System.Collections.Generic;

using System.IO;
using CustomStructures;
using CustomExtensions;

namespace Hercules_Prt
{
    class PrtHTML
    {
        private static String _htmlHdr = "<html><head><title>";
        private static String _htmlEndHdr = "</title></head><body><h1 align=center>";
        private static String _htmlTable = "</h1><center><table><tr><td><pre>";
        private static String _htmlHorzLine = "<hr>";
        private static String _htmlEndTable = "</pre></td></tr></table></center>";
        private static String _htmlEnd = "</body></html>";
        private static String _htmlNL = Environment.NewLine;

        public XMLHerculesPrt XMLHerculesPrt { get; private set; } = null;

        public PrtHTML(XMLHerculesPrt cfg)
        {
            XMLHerculesPrt = cfg;
        }

        public void ProcessReport(List<List<String>> document, List<CustomFieldValue> bojFieldValues, List<CustomFieldValue> eojFieldValues)
        {
            String docPath = XMLHerculesPrt.HTMLOutput.OutputDir;
            String docName = XMLHerculesPrt.HTMLOutput.OutputFileTemplate;
            String titleName;

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

            if (!(docName.EndsWith(".html")))
            {
                docName += ".html";
            }

            if (!(docPath.EndsWith("\\")))
            {
                docPath += "\\";
            }

            titleName = docName.Substring(0, docName.Length - 5);
            docPath += docName;

            StreamWriter reportOut = new StreamWriter(docPath, false);
            reportOut.WriteLine(_htmlHdr + titleName);
            reportOut.WriteLine(_htmlEndHdr);
            if (XMLHerculesPrt.HTMLOutput.HTMLHeaderChecked.ToBool())
            {
                reportOut.WriteLine(titleName);
                reportOut.WriteLine(_htmlHorzLine);
            }
            reportOut.WriteLine(_htmlTable);

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
                    reportOut.WriteLine(item);
                }
                reportOut.WriteLine(_htmlHorzLine);
            }

            reportOut.WriteLine(_htmlEndTable);
            reportOut.WriteLine(_htmlEnd);

            reportOut.Flush();
            reportOut.Close();
            reportOut.Dispose();

        }
    }
}
