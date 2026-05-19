using System.IO;

namespace FileAnalyzer.Core.FileReaders
{
    public class TxtFileReader
    {
        public string ReadText(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(fs))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
