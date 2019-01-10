namespace steg_v2
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
            this.radioButtonHide = new System.Windows.Forms.RadioButton();
            this.radioButtonExtract = new System.Windows.Forms.RadioButton();
            this.labelInputImg = new System.Windows.Forms.Label();
            this.textBoxInputImgPath = new System.Windows.Forms.TextBox();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.textBoxOutputFilePath = new System.Windows.Forms.TextBox();
            this.buttonOutputFile = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.saveFileDialogOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.labelError = new System.Windows.Forms.Label();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.textBoxInputFilePath = new System.Windows.Forms.TextBox();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.labelOutputImage = new System.Windows.Forms.Label();
            this.textBoxOutputImagePath = new System.Windows.Forms.TextBox();
            this.buttonOutputImage = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.openFileDialogInputFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutputImage = new System.Windows.Forms.SaveFileDialog();
            this.buttonInputImgHide = new System.Windows.Forms.Button();
            this.openFileDialogInputImageHide = new System.Windows.Forms.OpenFileDialog();
            this.textBoxInputImgPathExtract = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogInputImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonInputImgExtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonHide
            // 
            this.radioButtonHide.AutoSize = true;
            this.radioButtonHide.Checked = true;
            this.radioButtonHide.Location = new System.Drawing.Point(12, 12);
            this.radioButtonHide.Name = "radioButtonHide";
            this.radioButtonHide.Size = new System.Drawing.Size(58, 21);
            this.radioButtonHide.TabIndex = 0;
            this.radioButtonHide.TabStop = true;
            this.radioButtonHide.Text = "Hide";
            this.radioButtonHide.UseVisualStyleBackColor = true;
            this.radioButtonHide.CheckedChanged += new System.EventHandler(this.radioButtonHide_CheckedChanged);
            // 
            // radioButtonExtract
            // 
            this.radioButtonExtract.AutoSize = true;
            this.radioButtonExtract.Location = new System.Drawing.Point(77, 13);
            this.radioButtonExtract.Name = "radioButtonExtract";
            this.radioButtonExtract.Size = new System.Drawing.Size(72, 21);
            this.radioButtonExtract.TabIndex = 1;
            this.radioButtonExtract.Text = "Extract";
            this.radioButtonExtract.UseVisualStyleBackColor = true;
            this.radioButtonExtract.CheckedChanged += new System.EventHandler(this.radioButtonExtract_CheckedChanged);
            // 
            // labelInputImg
            // 
            this.labelInputImg.AutoSize = true;
            this.labelInputImg.Location = new System.Drawing.Point(13, 42);
            this.labelInputImg.Name = "labelInputImg";
            this.labelInputImg.Size = new System.Drawing.Size(81, 17);
            this.labelInputImg.TabIndex = 3;
            this.labelInputImg.Text = "Input image";
            // 
            // textBoxInputImgPath
            // 
            this.textBoxInputImgPath.Location = new System.Drawing.Point(110, 39);
            this.textBoxInputImgPath.Name = "textBoxInputImgPath";
            this.textBoxInputImgPath.ReadOnly = true;
            this.textBoxInputImgPath.Size = new System.Drawing.Size(211, 22);
            this.textBoxInputImgPath.TabIndex = 4;
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(13, 74);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(73, 17);
            this.labelOutputFile.TabIndex = 5;
            this.labelOutputFile.Text = "Output file";
            this.labelOutputFile.Visible = false;
            // 
            // textBoxOutputFilePath
            // 
            this.textBoxOutputFilePath.Location = new System.Drawing.Point(110, 71);
            this.textBoxOutputFilePath.Name = "textBoxOutputFilePath";
            this.textBoxOutputFilePath.ReadOnly = true;
            this.textBoxOutputFilePath.Size = new System.Drawing.Size(211, 22);
            this.textBoxOutputFilePath.TabIndex = 6;
            this.textBoxOutputFilePath.Visible = false;
            // 
            // buttonOutputFile
            // 
            this.buttonOutputFile.Location = new System.Drawing.Point(329, 71);
            this.buttonOutputFile.Name = "buttonOutputFile";
            this.buttonOutputFile.Size = new System.Drawing.Size(87, 23);
            this.buttonOutputFile.TabIndex = 7;
            this.buttonOutputFile.Text = "Browse";
            this.buttonOutputFile.UseVisualStyleBackColor = true;
            this.buttonOutputFile.Visible = false;
            this.buttonOutputFile.Click += new System.EventHandler(this.buttonOutputFile_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(12, 133);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(75, 23);
            this.buttonExtract.TabIndex = 8;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Visible = false;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(100, 139);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 9;
            this.labelError.Visible = false;
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(13, 74);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(61, 17);
            this.labelInputFile.TabIndex = 10;
            this.labelInputFile.Text = "Input file";
            // 
            // textBoxInputFilePath
            // 
            this.textBoxInputFilePath.Location = new System.Drawing.Point(110, 71);
            this.textBoxInputFilePath.Name = "textBoxInputFilePath";
            this.textBoxInputFilePath.ReadOnly = true;
            this.textBoxInputFilePath.Size = new System.Drawing.Size(211, 22);
            this.textBoxInputFilePath.TabIndex = 12;
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(329, 71);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(87, 23);
            this.buttonInputFile.TabIndex = 13;
            this.buttonInputFile.Text = "Browse";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.buttonInputFile_Click);
            // 
            // labelOutputImage
            // 
            this.labelOutputImage.AutoSize = true;
            this.labelOutputImage.Location = new System.Drawing.Point(13, 105);
            this.labelOutputImage.Name = "labelOutputImage";
            this.labelOutputImage.Size = new System.Drawing.Size(93, 17);
            this.labelOutputImage.TabIndex = 14;
            this.labelOutputImage.Text = "Output image";
            // 
            // textBoxOutputImagePath
            // 
            this.textBoxOutputImagePath.Location = new System.Drawing.Point(110, 102);
            this.textBoxOutputImagePath.Name = "textBoxOutputImagePath";
            this.textBoxOutputImagePath.ReadOnly = true;
            this.textBoxOutputImagePath.Size = new System.Drawing.Size(211, 22);
            this.textBoxOutputImagePath.TabIndex = 15;
            // 
            // buttonOutputImage
            // 
            this.buttonOutputImage.Location = new System.Drawing.Point(329, 102);
            this.buttonOutputImage.Name = "buttonOutputImage";
            this.buttonOutputImage.Size = new System.Drawing.Size(87, 23);
            this.buttonOutputImage.TabIndex = 16;
            this.buttonOutputImage.Text = "Browse";
            this.buttonOutputImage.UseVisualStyleBackColor = true;
            this.buttonOutputImage.Click += new System.EventHandler(this.buttonOutputImage_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(11, 133);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(75, 23);
            this.buttonHide.TabIndex = 17;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // openFileDialogInputFile
            // 
            this.openFileDialogInputFile.FileName = "openFileDialog1";
            this.openFileDialogInputFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogInputFile_FileOk);
            // 
            // saveFileDialogOutputImage
            // 
            this.saveFileDialogOutputImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogOutputImage_FileOk);
            // 
            // buttonInputImgHide
            // 
            this.buttonInputImgHide.Location = new System.Drawing.Point(329, 38);
            this.buttonInputImgHide.Name = "buttonInputImgHide";
            this.buttonInputImgHide.Size = new System.Drawing.Size(87, 23);
            this.buttonInputImgHide.TabIndex = 18;
            this.buttonInputImgHide.Text = "Browse";
            this.buttonInputImgHide.UseVisualStyleBackColor = true;
            this.buttonInputImgHide.Click += new System.EventHandler(this.buttonInputImgHide_Click);
            // 
            // openFileDialogInputImageHide
            // 
            this.openFileDialogInputImageHide.FileName = "openFileDialog1";
            this.openFileDialogInputImageHide.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogInputImageHide_FileOk);
            // 
            // textBoxInputImgPathExtract
            // 
            this.textBoxInputImgPathExtract.Location = new System.Drawing.Point(110, 39);
            this.textBoxInputImgPathExtract.Name = "textBoxInputImgPathExtract";
            this.textBoxInputImgPathExtract.ReadOnly = true;
            this.textBoxInputImgPathExtract.Size = new System.Drawing.Size(211, 22);
            this.textBoxInputImgPathExtract.TabIndex = 19;
            this.textBoxInputImgPathExtract.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialogInputImage
            // 
            this.openFileDialogInputImage.FileName = "openFileDialog2";
            // 
            // buttonInputImgExtract
            // 
            this.buttonInputImgExtract.Location = new System.Drawing.Point(329, 38);
            this.buttonInputImgExtract.Name = "buttonInputImgExtract";
            this.buttonInputImgExtract.Size = new System.Drawing.Size(87, 23);
            this.buttonInputImgExtract.TabIndex = 20;
            this.buttonInputImgExtract.Text = "Browse";
            this.buttonInputImgExtract.UseVisualStyleBackColor = true;
            this.buttonInputImgExtract.Visible = false;
            this.buttonInputImgExtract.Click += new System.EventHandler(this.buttonInputImgExtract_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 168);
            this.Controls.Add(this.buttonInputImgExtract);
            this.Controls.Add(this.textBoxInputImgPathExtract);
            this.Controls.Add(this.buttonInputImgHide);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonOutputImage);
            this.Controls.Add(this.textBoxOutputImagePath);
            this.Controls.Add(this.labelOutputImage);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.textBoxInputFilePath);
            this.Controls.Add(this.labelInputFile);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonOutputFile);
            this.Controls.Add(this.textBoxOutputFilePath);
            this.Controls.Add(this.labelOutputFile);
            this.Controls.Add(this.textBoxInputImgPath);
            this.Controls.Add(this.labelInputImg);
            this.Controls.Add(this.radioButtonExtract);
            this.Controls.Add(this.radioButtonHide);
            this.Name = "Form1";
            this.Text = "steg_v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonHide;
        private System.Windows.Forms.RadioButton radioButtonExtract;
        private System.Windows.Forms.Label labelInputImg;
        private System.Windows.Forms.TextBox textBoxInputImgPath;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.TextBox textBoxOutputFilePath;
        private System.Windows.Forms.Button buttonOutputFile;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputFile;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.TextBox textBoxInputFilePath;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.Label labelOutputImage;
        private System.Windows.Forms.TextBox textBoxOutputImagePath;
        private System.Windows.Forms.Button buttonOutputImage;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.OpenFileDialog openFileDialogInputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputImage;
        private System.Windows.Forms.Button buttonInputImgHide;
        private System.Windows.Forms.OpenFileDialog openFileDialogInputImageHide;
        private System.Windows.Forms.TextBox textBoxInputImgPathExtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogInputImage;
        private System.Windows.Forms.Button buttonInputImgExtract;
    }
}

