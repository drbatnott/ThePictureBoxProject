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
        public pictureBoxForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg)|*.jpg| (*.bmp)|*.bmp|PNG (*.png)|*.png";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                penguinPictureBox.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
