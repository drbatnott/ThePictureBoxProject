
namespace ThePictureBoxProject
{
    partial class pictureBoxForm
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
            this.penguinPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.penguinPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // penguinPictureBox
            // 
            this.penguinPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penguinPictureBox.Image = global::ThePictureBoxProject.Properties.Resources.WIN_20210913_13_50_05_Pro;
            this.penguinPictureBox.Location = new System.Drawing.Point(0, 0);
            this.penguinPictureBox.Name = "penguinPictureBox";
            this.penguinPictureBox.Size = new System.Drawing.Size(800, 450);
            this.penguinPictureBox.TabIndex = 0;
            this.penguinPictureBox.TabStop = false;
            // 
            // pictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.penguinPictureBox);
            this.Name = "pictureBoxForm";
            this.Text = "Picture Box Example";
            ((System.ComponentModel.ISupportInitialize)(this.penguinPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox penguinPictureBox;
    }
}

