using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Session6IOWorkingWithFilesImagesWinForms
{
    public partial class VSNotepad : Form
    {
        private string fullFileName = "";
        public VSNotepad()
        {
            InitializeComponent();
        }

      /*  private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            
        }*/

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the FileExplorer Directory on the local PC-> Target
            //Take a folder in which we will save the notepad file
            //In dr I hold the selected resulst(THE PATH -> NOT USED)
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            //path to the file
            string folderPath = folderBrowserDialog1.SelectedPath;
            //name of the file
            string fileName = txtBoxFileName.Text+cmbBoxExtensions.SelectedText.ToString();//I would like add a drop down to selecte .pdf, .jpg etc. 
            string fullFileName = folderPath + "\\" + fileName;

            //Create file tests.txt
            //In File Class the Create Method is a static method -> that`s why It can be called without new
            using FileStream fs = File.Create(fullFileName);
            {
                //UTF8Enconding GetBytes() -> From a string returns a bytes array.
                //Call the constructor UTF8Encoding
                byte[] content = new UTF8Encoding().GetBytes(richTextBox1.Text);
                //method Write from class FileStream is called by the fs Object
                fs.Write(content, 0, content.Length);
                //In Filestrean we write the content. Start from position 0 and write the lenght

            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult dr = folderBrowserDialog1.ShowDialog();
            //path to the file
            //string folderPath = folderBrowserDialog1.SelectedPath;
            //print the text from the file
            //Method ShowDialog is called by the openFileDialog1
            openFileDialog1.ShowDialog();
            //fullFileName -> global so that it can be used in other methods
            fullFileName = openFileDialog1.FileName;
            //https://stackoverflow.com/questions/25807209/validate-uploaded-file-extension
            if (Path.GetExtension(fullFileName) == ".txt")
            {
                using FileStream fs = File.OpenRead(fullFileName);
                {
                    //fs.Length return the length of the file(text inside the file) and create byte array of the length(fs.Length)
                    byte[] content = new byte[fs.Length];
                    //sugested fix from InteliSense
                    UTF8Encoding encoder = new();
                    //UTF8Encoding encoder = new UTF8Encoding();
                    fs.Read(content, 0, content.Length);
                    //transfrom from bytes to string
                    richTextBox1.Text = encoder.GetString(content);

                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullFileName != "")
            {
                using (FileStream fs = File.Create(fullFileName))
                {
                    //UTF8Enconding GetBytes() -> From a string returns a bytes array.
                    byte[] content = new UTF8Encoding().GetBytes(richTextBox1.Text);
                    fs.Write(content, 0, content.Length);
                    //In Filestrean we write the content. Start from position 0 and write the lenght

                }
            }
            else
            {
                MessageBox.Show("File must be selected before editing! ");
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullFileName != "")
            {
                using (FileStream fs = File.Create(fullFileName))
                {
                    //UTF8Enconding GetBytes() -> From a string returns a bytes array.
                    byte[] content = new UTF8Encoding().GetBytes(richTextBox1.Text);
                    fs.Write(content, 0, content.Length);
                    //In Filestrean we write the content. Start from position 0 and write the lenght

                }
            }
            
            MessageBox.Show("You forgot to save the changes. We got your back! ");

            this.Close();
        }

        private void txtBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
