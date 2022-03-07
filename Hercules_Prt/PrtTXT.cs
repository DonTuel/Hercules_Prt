using System;
using System.Collections.Generic;

using System.IO;
using CustomStructures;
using CustomExtensions;

namespace Hercules_Prt
{
    class PrtTXT
    {
        public XMLHerculesPrt XMLHerculesPrt { get; private set; } = null;

        public PrtTXT(XMLHerculesPrt cfg)
        {
            XMLHerculesPrt = cfg;
        }

        public void ProcessReport(List<List<String>> document, List<CustomFieldValue> bojFieldValues, List<CustomFieldValue> eojFieldValues)
        {
            String docPath = XMLHerculesPrt.TXTOutput.OutputDir;
            String docName = XMLHerculesPrt.TXTOutput.OutputFileTemplate;

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

            if (!(docName.EndsWith(".txt")))
            {
                docName += ".txt";
            }

            if (!(docPath.EndsWith("\\")))
            {
                docPath += "\\";
            }

            docPath += docName;

            StreamWriter reportOut = new StreamWriter(docPath, false);

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
                reportOut.WriteLine("\f");
            }

            reportOut.Flush();
            reportOut.Close();
            reportOut.Dispose();

        }
    }
}
