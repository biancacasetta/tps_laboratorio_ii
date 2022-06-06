
namespace TP3
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pbLogoEcoCenter = new System.Windows.Forms.PictureBox();
            this.pbCursos = new System.Windows.Forms.PictureBox();
            this.pbEstudiantes = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEcoCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogoEcoCenter
            // 
            this.pbLogoEcoCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogoEcoCenter.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoEcoCenter.Image")));
            this.pbLogoEcoCenter.Location = new System.Drawing.Point(34, 12);
            this.pbLogoEcoCenter.Name = "pbLogoEcoCenter";
            this.pbLogoEcoCenter.Size = new System.Drawing.Size(276, 125);
            this.pbLogoEcoCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoEcoCenter.TabIndex = 0;
            this.pbLogoEcoCenter.TabStop = false;
            this.pbLogoEcoCenter.Click += new System.EventHandler(this.pbLogoEcoCenter_Click);
            // 
            // pbCursos
            // 
            this.pbCursos.BackColor = System.Drawing.Color.White;
            this.pbCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCursos.Image = ((System.Drawing.Image)(resources.GetObject("pbCursos.Image")));
            this.pbCursos.Location = new System.Drawing.Point(513, 12);
            this.pbCursos.Name = "pbCursos";
            this.pbCursos.Size = new System.Drawing.Size(125, 125);
            this.pbCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCursos.TabIndex = 2;
            this.pbCursos.TabStop = false;
            this.pbCursos.Click += new System.EventHandler(this.pbCursos_Click);
            // 
            // pbEstudiantes
            // 
            this.pbEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("pbEstudiantes.Image")));
            this.pbEstudiantes.Location = new System.Drawing.Point(339, 12);
            this.pbEstudiantes.Name = "pbEstudiantes";
            this.pbEstudiantes.Size = new System.Drawing.Size(125, 125);
            this.pbEstudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEstudiantes.TabIndex = 3;
            this.pbEstudiantes.TabStop = false;
            this.pbEstudiantes.Click += new System.EventHandler(this.pbEstudiantes_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.Location = new System.Drawing.Point(12, 156);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(980, 544);
            this.pnlMenuVertical.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 150);
            this.panel1.TabIndex = 6;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pbEstudiantes);
            this.Controls.Add(this.pbCursos);
            this.Controls.Add(this.pbLogoEcoCenter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECO CENTER - School of English";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEcoCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoEcoCenter;
        private System.Windows.Forms.PictureBox pbCursos;
        private System.Windows.Forms.PictureBox pbEstudiantes;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        protected System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

