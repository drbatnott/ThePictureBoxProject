
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startedTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.drawingCanvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.penguinPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // penguinPictureBox
            // 
            this.penguinPictureBox.Image = global::ThePictureBoxProject.Properties.Resources.WIN_20210913_13_50_05_Pro;
            this.penguinPictureBox.Location = new System.Drawing.Point(12, 27);
            this.penguinPictureBox.Name = "penguinPictureBox";
            this.penguinPictureBox.Size = new System.Drawing.Size(650, 484);
            this.penguinPictureBox.TabIndex = 0;
            this.penguinPictureBox.TabStop = false;
            this.penguinPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.penguinPictureBox_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.drawToolStripMenuItem.Text = "Draw";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // startedTextBox
            // 
            this.startedTextBox.Location = new System.Drawing.Point(668, 44);
            this.startedTextBox.Name = "startedTextBox";
            this.startedTextBox.Size = new System.Drawing.Size(83, 20);
            this.startedTextBox.TabIndex = 2;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(668, 88);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(83, 20);
            this.xTextBox.TabIndex = 3;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(668, 145);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(83, 20);
            this.yTextBox.TabIndex = 4;
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.Location = new System.Drawing.Point(740, 309);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(185, 202);
            this.drawingCanvas.TabIndex = 5;
            // 
            // pictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 580);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.startedTextBox);
            this.Controls.Add(this.penguinPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pictureBoxForm";
            this.Text = "Picture Box Example";
            ((System.ComponentModel.ISupportInitialize)(this.penguinPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox penguinPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.TextBox startedTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Panel drawingCanvas;
    }
}

