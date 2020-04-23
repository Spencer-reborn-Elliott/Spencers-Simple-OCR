using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Spencer_s_Simple_OCR
{
    public partial class Form1 : Form
    {
        string Title = "Spencer's Simple OCR";
        DirectoryInfo InputFolderDir;
        bool InputFolderSet = false;
        string temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectImageFolder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SelectImageFolder.SelectedPath))
            {
                InputFolderDir = new DirectoryInfo(SelectImageFolder.SelectedPath);
                InputFolderSet = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (InputFolderSet == true)
            {
                Convert();
            }
            else
            {
                MessageBox.Show("You must set the input folder first before trying to convert files.", Title);
            }
        }


        void Convert()
        {
            temp = "";
            ProcessingScreen.Text = "";
            var ext = new List<string> { ".bmp", ".png", ".jpeg", ".jpg", ".tiff" };
            foreach (var file in InputFolderDir.GetFiles("*.*", SearchOption.TopDirectoryOnly).Where(s => ext.Contains(Path.GetExtension(s.FullName).ToLowerInvariant())))
            {
                Bitmap img = new Bitmap(file.FullName);
                ProcessBitmapImage(img, file.Name);
            }
            if (CombineFiles.Checked == true)
            {
                string path = SelectImageFolder.SelectedPath + @"\" + "Combined.txt";
                File.WriteAllText(path, temp);
            }
        }



        void ProcessBitmapImage(Bitmap imgsource, string SourceFileName)
        {
            string ocrtext;
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var img = PixConverter.ToPix(imgsource))
                {
                    using (var page = engine.Process(img))
                    {
                        ocrtext = page.GetText();
                        LogIt(ocrtext);
                        if(CombineFiles.Checked == true)
                        {
                            temp = temp + ocrtext;
                        }
                        else
                        {
                            string path = SelectImageFolder.SelectedPath + @"\" + SourceFileName + ".txt";
                            File.WriteAllText(path, ocrtext);
                        }
                    }
                }
            }
        }



        void LogIt(string message)
        {
            ProcessingScreen.Text = ProcessingScreen.Text + DateTime.Now.ToString() + ":   " + message + "\n";
            ProcessingScreen.Focus();
            ProcessingScreen.SelectionStart = ProcessingScreen.Text.Length;
            ProcessingScreen.ScrollToCaret();
        }

    }
}
