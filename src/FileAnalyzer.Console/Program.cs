using System;
using System.IO;
using System.Windows.Forms;
using FileAnalyzer.Core;
using FileAnalyzer.Core.FileReaders;

namespace FileAnalyzer.ConsoleApp
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string filePath = SelectFile();

            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("No file selected.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            try
            {
                string content = ReadFile(filePath);
                var analyzer = new TextAnalyzer();
                Console.WriteLine(analyzer.AnalyzeFile(content));
            }
            catch (Exception ex)
            {
                LogError(ex);
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static string SelectFile()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx|PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "File Analyzer";

                return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : string.Empty;
            }
        }

        private static string ReadFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (extension == ".txt")
            {
                return new TxtFileReader().ReadText(filePath);
            }

            if (extension == ".docx")
            {
                return new DocxFileReader().ReadText(filePath);
            }

            if (extension == ".pdf")
            {
                return new PdfFileReader().ReadText(filePath);
            }

            throw new NotSupportedException("Unsupported file type");
        }

        private static void LogError(Exception ex)
        {
            Directory.CreateDirectory("Logs");
            string logPath = Path.Combine("Logs", "log.txt");
            File.AppendAllText(logPath, Environment.UserName + Environment.NewLine);
            File.AppendAllText(logPath, DateTime.Now.ToString("dd.MM.yyyy HH.mm") + Environment.NewLine);
            File.AppendAllText(logPath, ex.Message + Environment.NewLine);
            File.AppendAllText(logPath, ex.StackTrace + Environment.NewLine + Environment.NewLine);
        }
    }
}
