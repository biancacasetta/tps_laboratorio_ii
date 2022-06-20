
namespace TP4
{
    partial class FrmBibliografia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBibliografia));
            this.rtbBibliografia = new System.Windows.Forms.RichTextBox();
            this.lblBibliografia = new System.Windows.Forms.Label();
            this.lblPortadas = new System.Windows.Forms.Label();
            this.imlPortadas = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // rtbBibliografia
            // 
            this.rtbBibliografia.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbBibliografia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbBibliografia.Location = new System.Drawing.Point(27, 88);
            this.rtbBibliografia.Name = "rtbBibliografia";
            this.rtbBibliografia.ReadOnly = true;
            this.rtbBibliografia.Size = new System.Drawing.Size(522, 343);
            this.rtbBibliografia.TabIndex = 0;
            this.rtbBibliografia.Text = "";
            // 
            // lblBibliografia
            // 
            this.lblBibliografia.AutoSize = true;
            this.lblBibliografia.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBibliografia.Location = new System.Drawing.Point(144, 34);
            this.lblBibliografia.Name = "lblBibliografia";
            this.lblBibliografia.Size = new System.Drawing.Size(298, 28);
            this.lblBibliografia.TabIndex = 1;
            this.lblBibliografia.Text = "BIBLIOGRAFIA DE CURSOS";
            // 
            // lblPortadas
            // 
            this.lblPortadas.ImageIndex = 0;
            this.lblPortadas.ImageList = this.imlPortadas;
            this.lblPortadas.Location = new System.Drawing.Point(566, 133);
            this.lblPortadas.Name = "lblPortadas";
            this.lblPortadas.Size = new System.Drawing.Size(200, 250);
            this.lblPortadas.TabIndex = 2;
            this.lblPortadas.Text = "label1";
            // 
            // imlPortadas
            // 
            this.imlPortadas.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlPortadas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPortadas.ImageStream")));
            this.imlPortadas.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPortadas.Images.SetKeyName(0, "English File 1.png");
            this.imlPortadas.Images.SetKeyName(1, "English File 2.png");
            this.imlPortadas.Images.SetKeyName(2, "English File 3.png");
            this.imlPortadas.Images.SetKeyName(3, "English File 4.png");
            this.imlPortadas.Images.SetKeyName(4, "English File 5.png");
            this.imlPortadas.Images.SetKeyName(5, "English File 6.png");
            // 
            // FrmBibliografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 443);
            this.Controls.Add(this.lblPortadas);
            this.Controls.Add(this.lblBibliografia);
            this.Controls.Add(this.rtbBibliografia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBibliografia";
            this.Text = "FrmBibliografia";
            this.Load += new System.EventHandler(this.FrmBibliografia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBibliografia;
        private System.Windows.Forms.Label lblBibliografia;
        private System.Windows.Forms.Label lblPortadas;
        private System.Windows.Forms.ImageList imlPortadas;
    }
}