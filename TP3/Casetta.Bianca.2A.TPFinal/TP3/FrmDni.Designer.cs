
namespace TP3
{
    partial class FrmDni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDni));
            this.lblIngresarDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarDni
            // 
            this.lblIngresarDni.AutoSize = true;
            this.lblIngresarDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresarDni.Location = new System.Drawing.Point(247, 212);
            this.lblIngresarDni.Name = "lblIngresarDni";
            this.lblIngresarDni.Size = new System.Drawing.Size(300, 22);
            this.lblIngresarDni.TabIndex = 0;
            this.lblIngresarDni.Text = "INGRESE EL DNI DEL ESTUDIANTE";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(247, 250);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(300, 30);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(687, 384);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(125, 125);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 0;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(552, 384);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(125, 125);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmar.TabIndex = 0;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Click += new System.EventHandler(this.pbConfirmar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(275, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 28);
            this.lblTitulo.TabIndex = 1;
            // 
            // FrmDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 521);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblIngresarDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDni";
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.PictureBox pbConfirmar;
        private System.Windows.Forms.Label lblTitulo;
    }
}