namespace Spencer_s_Simple_OCR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.SelectImageFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.ProcessingScreen = new System.Windows.Forms.RichTextBox();
            this.CombineFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 72);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(140, 28);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder Of Images";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(893, 366);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ProcessingScreen
            // 
            this.ProcessingScreen.Location = new System.Drawing.Point(12, 255);
            this.ProcessingScreen.Name = "ProcessingScreen";
            this.ProcessingScreen.ReadOnly = true;
            this.ProcessingScreen.Size = new System.Drawing.Size(956, 105);
            this.ProcessingScreen.TabIndex = 2;
            this.ProcessingScreen.Text = "Processing screen";
            // 
            // CombineFiles
            // 
            this.CombineFiles.AutoSize = true;
            this.CombineFiles.Location = new System.Drawing.Point(14, 116);
            this.CombineFiles.Name = "CombineFiles";
            this.CombineFiles.Size = new System.Drawing.Size(164, 17);
            this.CombineFiles.TabIndex = 3;
            this.CombineFiles.Text = "Combine into one document?";
            this.CombineFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "This application will allow you to select a folder of images and then convert the" +
    "m into text files. You can choose to keep the files separate, or merge them into" +
    " one large text file.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Currently supports .bmp, .png, .tiff and jpeg files. Support for PDF files is bei" +
    "ng developed.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CombineFiles);
            this.Controls.Add(this.ProcessingScreen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnChooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spencer\'s Simple OCR v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog SelectImageFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox ProcessingScreen;
        private System.Windows.Forms.CheckBox CombineFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

