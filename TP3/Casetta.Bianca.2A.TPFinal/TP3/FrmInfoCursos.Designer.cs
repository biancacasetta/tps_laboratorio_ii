
namespace TP3
{
    partial class FrmInfoCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoCursos));
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.rtbInfoCurso = new System.Windows.Forms.RichTextBox();
            this.pbExportar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(340, 45);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(191, 30);
            this.cmbCursos.TabIndex = 0;
            this.cmbCursos.TextChanged += new System.EventHandler(this.cmbCursos_TextChanged);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccion.Location = new System.Drawing.Point(134, 48);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(200, 22);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "SELECCIONE UN CURSO";
            // 
            // rtbInfoCurso
            // 
            this.rtbInfoCurso.BackColor = System.Drawing.Color.White;
            this.rtbInfoCurso.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbInfoCurso.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbInfoCurso.Location = new System.Drawing.Point(46, 98);
            this.rtbInfoCurso.Name = "rtbInfoCurso";
            this.rtbInfoCurso.ReadOnly = true;
            this.rtbInfoCurso.Size = new System.Drawing.Size(568, 327);
            this.rtbInfoCurso.TabIndex = 2;
            this.rtbInfoCurso.Text = "";
            // 
            // pbExportar
            // 
            this.pbExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExportar.Image = ((System.Drawing.Image)(resources.GetObject("pbExportar.Image")));
            this.pbExportar.Location = new System.Drawing.Point(646, 98);
            this.pbExportar.Name = "pbExportar";
            this.pbExportar.Size = new System.Drawing.Size(125, 125);
            this.pbExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExportar.TabIndex = 27;
            this.pbExportar.TabStop = false;
            this.pbExportar.Click += new System.EventHandler(this.pbExportar_Click);
            // 
            // FrmInfoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.pbExportar);
            this.Controls.Add(this.rtbInfoCurso);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.cmbCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfoCursos";
            this.Text = "InfoCursos";
            this.Load += new System.EventHandler(this.InfoCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.RichTextBox rtbInfoCurso;
        private System.Windows.Forms.PictureBox pbExportar;
    }
}