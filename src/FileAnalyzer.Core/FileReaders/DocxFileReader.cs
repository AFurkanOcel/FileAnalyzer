using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace FileAnalyzer.Core.FileReaders
{
    public class DocxFileReader
    {
        public string ReadText(string filePath)
        {
            var sb = new StringBuilder();

            using (var docx = WordprocessingDocument.Open(filePath, false))
            {
                Body body = docx.MainDocumentPart.Document.Body;

                foreach (var paragraph in body.Elements<Paragraph>())
                {
                    sb.AppendLine(paragraph.InnerText);
                }
            }

            return sb.ToString();
        }
    }
}
