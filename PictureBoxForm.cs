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
        
        Point currentPos, lastPos;
        List<Point> points;
        bool drawingStarted = false;
        public pictureBoxForm()
        {
            InitializeComponent();
            startedTextBox.Text = drawingStarted.ToString();
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

        private void penguinPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (drawingStarted)
            {
                Graphics g = penguinPictureBox.CreateGraphics();
                Image b = penguinPictureBox.Image;
                int x = b.Width * (e.X )/ penguinPictureBox.Width;
                int y = b.Height * (e.Y ) / penguinPictureBox.Height;
                currentPos = new Point(x,y);

                points.Add(currentPos);
                xTextBox.Text = x.ToString();
                yTextBox.Text = y.ToString();
                lastPos = points[0];
                Pen p = new Pen(Color.Black, 7);
                for(int i = 1; i < points.Count; i++)
                {
                    currentPos = points[i];
                    g.DrawLine(p, lastPos, currentPos);
                    lastPos = currentPos;
                }
            }
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                currentPos = new Point();
                points = new List<Point>();
                drawingStarted = true;
                startedTextBox.Text = drawingStarted.ToString();
           
            lastPos = currentPos;
        }
    }
}
