using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePictureBoxProject
{
    public partial class pictureBoxForm : Form
    {
        string currentFileName = "";
        public pictureBoxForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "Image Files JPEG (*.jpg)|*.jpg| BMP (*.bmp)|*.bmp|PNG (*.png)|*.png";
            ofd.FileName = currentFileName;
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                currentFileName = ofd.FileName;
                penguinPictureBox.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
