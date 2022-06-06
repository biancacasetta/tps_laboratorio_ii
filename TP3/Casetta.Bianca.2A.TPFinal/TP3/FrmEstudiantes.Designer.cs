
namespace TP3
{
    partial class FrmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiantes));
            this.pbAlta = new System.Windows.Forms.PictureBox();
            this.pbBaja = new System.Windows.Forms.PictureBox();
            this.pbModificacion = new System.Windows.Forms.PictureBox();
            this.pbListado = new System.Windows.Forms.PictureBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlta
            // 
            this.pbAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlta.Image = ((System.Drawing.Image)(resources.GetObject("pbAlta.Image")));
            this.pbAlta.Location = new System.Drawing.Point(12, 12);
            this.pbAlta.Name = "pbAlta";
            this.pbAlta.Size = new System.Drawing.Size(125, 125);
            this.pbAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlta.TabIndex = 0;
            this.pbAlta.TabStop = false;
            this.pbAlta.Click += new System.EventHandler(this.pbAlta_Click);
            // 
            // pbBaja
            // 
            this.pbBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBaja.Image = ((System.Drawing.Image)(resources.GetObject("pbBaja.Image")));
            this.pbBaja.Location = new System.Drawing.Point(12, 143);
            this.pbBaja.Name = "pbBaja";
            this.pbBaja.Size = new System.Drawing.Size(125, 125);
            this.pbBaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBaja.TabIndex = 1;
            this.pbBaja.TabStop = false;
            this.pbBaja.Click += new System.EventHandler(this.pbBaja_Click);
            // 
            // pbModificacion
            // 
            this.pbModificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbModificacion.Image = ((System.Drawing.Image)(resources.GetObject("pbModificacion.Image")));
            this.pbModificacion.Location = new System.Drawing.Point(12, 274);
            this.pbModificacion.Name = "pbModificacion";
            this.pbModificacion.Size = new System.Drawing.Size(125, 125);
            this.pbModificacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModificacion.TabIndex = 2;
            this.pbModificacion.TabStop = false;
            this.pbModificacion.Click += new System.EventHandler(this.pbModificacion_Click);
            // 
            // pbListado
            // 
            this.pbListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbListado.Image = ((System.Drawing.Image)(resources.GetObject("pbListado.Image")));
            this.pbListado.Location = new System.Drawing.Point(12, 405);
            this.pbListado.Name = "pbListado";
            this.pbListado.Size = new System.Drawing.Size(125, 125);
            this.pbListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListado.TabIndex = 3;
            this.pbListado.TabStop = false;
            this.pbListado.Click += new System.EventHandler(this.pbListado_Click);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Location = new System.Drawing.Point(144, 12);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(824, 521);
            this.pnlCuerpo.TabIndex = 4;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 544);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pbListado);
            this.Controls.Add(this.pbModificacion);
            this.Controls.Add(this.pbBaja);
            this.Controls.Add(this.pbAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlta;
        private System.Windows.Forms.PictureBox pbBaja;
        private System.Windows.Forms.PictureBox pbModificacion;
        private System.Windows.Forms.PictureBox pbListado;
        private System.Windows.Forms.Panel pnlCuerpo;
    }
}