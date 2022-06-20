
namespace TP4
{
    partial class FrmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pbBibliografia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBibliografia)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInformacion
            // 
            this.pbInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInformacion.Image = ((System.Drawing.Image)(resources.GetObject("pbInformacion.Image")));
            this.pbInformacion.Location = new System.Drawing.Point(12, 12);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(125, 125);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInformacion.TabIndex = 0;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.Click += new System.EventHandler(this.pbInformacion_Click);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Location = new System.Drawing.Point(144, 12);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(824, 521);
            this.pnlCuerpo.TabIndex = 5;
            // 
            // pbBibliografia
            // 
            this.pbBibliografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBibliografia.Image = ((System.Drawing.Image)(resources.GetObject("pbBibliografia.Image")));
            this.pbBibliografia.Location = new System.Drawing.Point(13, 143);
            this.pbBibliografia.Name = "pbBibliografia";
            this.pbBibliografia.Size = new System.Drawing.Size(125, 125);
            this.pbBibliografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBibliografia.TabIndex = 6;
            this.pbBibliografia.TabStop = false;
            this.pbBibliografia.Click += new System.EventHandler(this.pbBibliografia_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 544);
            this.Controls.Add(this.pbBibliografia);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pbInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBibliografia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.PictureBox pbBibliografia;
    }
}