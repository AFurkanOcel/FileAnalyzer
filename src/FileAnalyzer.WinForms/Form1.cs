using System;
using System.IO;
using System.Windows.Forms;
using FileAnalyzer.Core;
using FileAnalyzer.Core.FileReaders;
using Newtonsoft.Json;

namespace FileAnalyzer.WinForms
{
    public partial class Form1 : Form
    {
        string filePath = "";
        string content = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AnalyzeBar.Value = 0;
                analyzeText.Text = "";
                filePathText.Text = "";

                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (txtCheckBox.Checked == true && docxCheckBox.Checked == true && pdfCheckBox.Checked == true)
                {
                    openFileDialog.Filter = "All files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";
                }
                else if (txtCheckBox.Checked == true && docxCheckBox.Checked == true && pdfCheckBox.Checked == false)
                {
                    openFileDialog.Filter = "All Files (*.txt;*.docx)|*.txt;*.docx|  Text Files (*.txt)|*.txt|  Word Documents (*.docx)|*.docx";
                }
                else if (txtCheckBox.Checked == true && docxCheckBox.Checked == false && pdfCheckBox.Checked == true)
                {
                    openFileDialog.Filter = "All Files (*.txt;*.pdf)|*.txt;*.pdf|  Text Files (*.txt)|*.txt|  PDF Files (*.pdf)|*.pdf";
                }
                else if (txtCheckBox.Checked == false && docxCheckBox.Checked == true && pdfCheckBox.Checked == true)
                {
                    openFileDialog.Filter = "All Files (*.docx;*.pdf)|*.docx;*.pdf|  Word Documents (*.docx)|*.docx|  PDF Files (*.pdf)|*.pdf";
                }
                else if (txtCheckBox.Checked == true && docxCheckBox.Checked == false && pdfCheckBox.Checked == false)
                {
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                }
                else if (txtCheckBox.Checked == false && docxCheckBox.Checked == true && pdfCheckBox.Checked == false)
                {
                    openFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                }
                else if (txtCheckBox.Checked == false && docxCheckBox.Checked == false && pdfCheckBox.Checked == true)
                {
                    openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                }
                else
                {
                    MessageBox.Show("No file type selected");
                    return;
                }

                openFileDialog.Title = "FileAnalyzer";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    filePathText.Text = openFileDialog.FileName;
                    filePathText.WordWrap = false;
                    filePathText.ScrollBars = RichTextBoxScrollBars.None;
                }
            }
            catch (Exception ex)
            {
                Directory.CreateDirectory("Logs");
                string logPath = Path.Combine("Logs", "log.txt");

                File.AppendAllText(logPath, Environment.UserName);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, DateTime.Now.ToString("dd.MM.yyyy HH.mm"));
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.Message);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.StackTrace);
                File.AppendAllText(logPath, Environment.NewLine);
            }
        }

        public void AnalyzeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePathText.Text == "")
                {
                    MessageBox.Show("Please select a file to analyze");
                    return;
                }
                else
                {
                    AnalyzeBar.Value += 50;

                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".txt")
                    {
                        var txtReader = new TxtFileReader();
                        content = txtReader.ReadText(filePath);
                    }
                    else if (extension == ".docx")
                    {
                        var txtReader = new DocxFileReader();
                        content = txtReader.ReadText(filePath);
                    }
                    else
                    {
                        var txtReader = new PdfFileReader();
                        content = txtReader.ReadText(filePath);
                    }

                    var analyzer = new TextAnalyzer();
                    string analyzeResult = analyzer.AnalyzeFile(content);

                    AnalyzeBar.Value += 50;
                    analyzeText.Text = analyzeResult;
                }
            }
            catch (Exception ex)
            {
                Directory.CreateDirectory("Logs");
                string logPath = Path.Combine("Logs", "log.txt");
                File.AppendAllText(logPath, Environment.UserName);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, DateTime.Now.ToString("dd.MM.yyyy HH.mm"));
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.Message);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.StackTrace);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, Environment.NewLine);
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (analyzeText.Text == "")
                {
                    MessageBox.Show("Please analyze a file before exporting");
                    return;
                }
                else
                {
                    Directory.CreateDirectory("AnalyzeResults");

                    if (ExJsonRdBtn.Checked)
                    {
                        string AnalyzedText = analyzeText.Text;
                        string json = JsonConvert.SerializeObject(AnalyzedText);
                        File.WriteAllText(@"AnalyzeResults\AnalyzeResult.json", json);

                        MessageBox.Show("Export completed");
                    }
                    else
                    {
                        string AnalyzedText = analyzeText.Text;
                        File.WriteAllText(@"AnalyzeResults\AnalyzeResult.txt", AnalyzedText);

                        MessageBox.Show("Export completed");
                    }
                }
            }
            catch (Exception ex)
            {
                Directory.CreateDirectory("Logs");
                string logPath = Path.Combine("Logs", "log.txt");
                File.AppendAllText(logPath, Environment.UserName);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, DateTime.Now.ToString("dd.MM.yyyy HH.mm"));
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.Message);
                File.AppendAllText(logPath, Environment.NewLine);
                File.AppendAllText(logPath, ex.StackTrace);
                File.AppendAllText(logPath, Environment.NewLine);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}


