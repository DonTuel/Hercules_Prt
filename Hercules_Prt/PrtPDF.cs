using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using CustomExtensions;
using CustomStructures;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using Rectangle = iText.Kernel.Geom.Rectangle;

namespace Hercules_Prt
{
    class PrtPDF
    {
        private static char _nbsp = (char)160;

        private PdfFont _font;
        private float marginTop;
        private float marginBottom;
        private float marginLeft;
        private float marginRight;
        private float fontSize;
        private float width;
        private float height;


        public XMLHerculesPrt XMLHerculesPrt { get; private set; } = null;

        public PrtPDF(XMLHerculesPrt cfg)
        {
            XMLHerculesPrt = cfg;
        }

        public void ProcessReport(List<List<String>> document, List<CustomFieldValue> bojFieldValues, List<CustomFieldValue> eojFieldValues)
        {
            String docPath = XMLHerculesPrt.PDFOutput.OutputDir;
            String docName = XMLHerculesPrt.PDFOutput.OutputFileTemplate;

            switch (XMLHerculesPrt.PDFOutput.PageSize)
            {
                case "Fanfold":
                    width = 14.875f * 72f;
                    height = 11f * 72f;
                    marginTop = -1.7f;
                    marginLeft = 0.0f;
                    marginBottom = -1.7f;
                    marginRight = 20.0f;
                    fontSize = 12.0f;
                    break;
                case "Letter":
                    width = 11f * 72f;
                    height = 8.5f * 72f;
                    marginTop = -1.9f;
                    marginLeft = 0.0f;
                    marginBottom = -1.9f;
                    marginRight = 0.0f;
                    fontSize = 10.0f;
                    break;
                default:
                    break;
            }

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

            if (!(docName.EndsWith(".pdf")))
            {
                docName += ".pdf";
            }

            if (!(docPath.EndsWith("\\")))
            {
                docPath += "\\";
            }

            docPath += docName;

            if (File.Exists(docPath))
            {
                File.Delete(docPath);
            }

            PdfWriter writer = new PdfWriter(docPath);
            PdfDocument pdf = new PdfDocument(writer);
            Rectangle rect = new Rectangle(width, height);
            PageSize pageSize = new PageSize(rect);
            Document doc = new Document(pdf, pageSize);

            _font = PdfFontFactory.CreateFont(StandardFonts.COURIER);

            Int32 iStart = 1;
            if (XMLHerculesPrt.CustomizationData.BOJCustomization.BOJPrintBanners.ToBool())
            {
                BuildPDFPage(doc, document[0]);
                doc.Add(new AreaBreak());
            }
            Int32 iEnd = document.Count - 1;

            for (int i = iStart; i < iEnd; i++)
            {
                BuildPDFPage(doc, document[i]);

                if (i < (iEnd - 1))
                {
                    doc.Add(new AreaBreak());
                }
            }

            if (XMLHerculesPrt.CustomizationData.EOJCustomization.EOJPrintBanners.ToBool())
            {
                doc.Add(new AreaBreak());
                BuildPDFPage(doc, document[document.Count - 1]);
            }

            doc.Close();
        }

        private void BuildPDFPage(Document doc, List<string> page)
        {
            foreach (var item in page)
            {
                string nItem = item.Replace(' ', _nbsp);
                if (nItem == "") { nItem = _nbsp.ToString(); }
                Text text = new Text(nItem);
                text.SetFont(_font);
                Paragraph par = new Paragraph(text);
                par.SetMargins(marginTop, marginRight, marginBottom, marginLeft); 
                par.SetFontSize(fontSize);
                doc.Add(par);
            }
        }
    }
}
