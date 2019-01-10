using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steg_v2
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void radioButtonHide_CheckedChanged(object sender, EventArgs e)
        {
            labelOutputFile.Visible = false;
            textBoxOutputFilePath.Visible = false;
            textBoxInputImgPathExtract.Visible = false;
            buttonOutputFile.Visible = false;
            buttonExtract.Visible = false;
            buttonInputImgExtract.Visible = false;
            labelInputFile.Visible = true;
            labelOutputImage.Visible = true;
            textBoxInputFilePath.Visible = true;
            textBoxInputFilePath.Text = "";
            textBoxOutputImagePath.Visible = true;
            textBoxOutputImagePath.Text = "";
            buttonInputFile.Visible = true;
            buttonOutputImage.Visible = true;
            buttonHide.Visible = true;
            buttonInputImgHide.Visible = true;
            textBoxInputImgPath.Visible = true;
            textBoxInputImgPath.Text = "";
            labelError.Text = "";
            controller.inputImg = null;
        }
        private void radioButtonExtract_CheckedChanged(object sender, EventArgs e)
        {
            labelOutputFile.Visible = true;
            textBoxOutputFilePath.Visible = true;
            textBoxOutputFilePath.Text = "";
            buttonOutputFile.Visible = true;
            buttonExtract.Visible = true;
            buttonInputImgExtract.Visible = true;
            textBoxInputImgPathExtract.Visible = true;
            textBoxInputImgPathExtract.Text = "";
            labelInputFile.Visible = false;
            labelOutputImage.Visible = false;
            textBoxInputFilePath.Visible = false;
            textBoxOutputImagePath.Visible = false;
            buttonInputFile.Visible = false;
            buttonOutputImage.Visible = false;
            buttonHide.Visible = false;
            buttonInputImgHide.Visible = false;
            textBoxInputImgPath.Visible = false;
            labelError.Text = "";
            controller.inputImg = null;
        }

        private void buttonInputImgExtract_Click_1(object sender, EventArgs e)
        {
            if (openFileDialogInputImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxInputImgPathExtract.Text = openFileDialogInputImage.FileName;

                try
                {
                    controller.inputImg = new ExtractImg(openFileDialogInputImage.FileName);
                }
                catch (ArgumentException ae)
                {
                    labelError.Text = ae.Message;
                    labelError.Visible = true;
                }
            }
        }
        private void buttonOutputFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutputFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutputFilePath.Text = saveFileDialogOutputFile.FileName;
                controller.inputImg.outputpath = saveFileDialogOutputFile.FileName;
            }
        }
        private void buttonInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogInputFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxInputFilePath.Text = openFileDialogInputFile.FileName;

                try
                {
                    controller.inputImg.fileToBytes(openFileDialogInputFile.FileName);
                }
                catch (ArgumentException ae)
                {
                    labelError.Text = ae.Message;
                    labelError.Visible = true;
                }
            }
        }
        private void buttonOutputImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutputImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutputImagePath.Text = saveFileDialogOutputImage.FileName;
                controller.inputImg.outputpath = saveFileDialogOutputImage.FileName;
            }
        }
        private void buttonInputImgHide_Click(object sender, EventArgs e)
        {
            if (openFileDialogInputImageHide.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxInputImgPath.Text = openFileDialogInputImageHide.FileName;

                try
                {
                    controller.inputImg = new HideImg(openFileDialogInputImageHide.FileName);
                }
                catch (ArgumentException ae)
                {
                    labelError.Text = ae.Message;
                    labelError.Visible = true;
                }
            }
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            controller.Extract();
            labelError.Text = "Done!";
            labelError.Visible = true;
        }
        private void buttonHide_Click(object sender, EventArgs e)
        {
            controller.Hide();
            labelError.Text = "Done!";
            labelError.Visible = true;
        }

        private void openFileDialogInputFile_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void saveFileDialogOutputImage_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void openFileDialogInputImage_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void openFileDialogInputImageHide_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
