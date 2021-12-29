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

namespace Session6PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            
            if (Path.GetExtension(filePath) == ".png")
            {
                pctBox.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show(".png extensions must be selected");
            }
                
        }
    }
}
