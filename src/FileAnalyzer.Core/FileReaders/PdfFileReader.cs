using System.Text;
using UglyToad.PdfPig;

namespace FileAnalyzer.Core.FileReaders
{
    public class PdfFileReader
    {
        public string ReadText(string filePath)
        {
            var sb = new StringBuilder();

            using (var pdf = PdfDocument.Open(filePath))
            {
                foreach (var page in pdf.GetPages())
                {
                    sb.AppendLine(page.Text);
                }
            }

            return sb.ToString();
        }
    }
}
