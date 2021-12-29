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
        private string fullFileName;
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
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            //path to the file
            string folderPath = folderBrowserDialog1.SelectedPath;
            //name of the file
            string fileName = "tests.txt";
            string fullFileName = folderPath + "\\" + fileName;
            //Create file tests.txt
            using (FileStream fs = File.Create(fullFileName))
            {
                //UTF8Enconding GetBytes() -> From a string returns a bytes array.
                byte[] content = new UTF8Encoding().GetBytes("Text from VS");
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
            openFileDialog1.ShowDialog();
            fullFileName = openFileDialog1.FileName;
            //https://stackoverflow.com/questions/25807209/validate-uploaded-file-extension
            if (Path.GetExtension(fullFileName) == ".txt")
            {
                using (FileStream fs = File.OpenRead(fullFileName))
                {
                    byte[] content = new byte[100];
                    UTF8Encoding encoder = new UTF8Encoding();
                    fs.Read(content, 0, content.Length);
                    //transfrom from bytes to string
                    richTextBox1.Text = encoder.GetString(content);

                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create(fullFileName))
            {
                //UTF8Enconding GetBytes() -> From a string returns a bytes array.
                byte[] content = new UTF8Encoding().GetBytes(richTextBox1.Text);
                fs.Write(content, 0, content.Length);
                //In Filestrean we write the content. Start from position 0 and write the lenght

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
