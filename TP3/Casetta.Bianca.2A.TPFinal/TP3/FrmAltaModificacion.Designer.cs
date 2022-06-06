
namespace TP3
{
    partial class FrmAltaModificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaModificacion));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.gpbDomicilio = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.gpbDatosContacto = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.pbLimpiar = new System.Windows.Forms.PictureBox();
            this.pbConfirmar = new System.Windows.Forms.PictureBox();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.epCampoIncompleto = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTipoEstudiante = new System.Windows.Forms.Label();
            this.cmbTipoEstudiante = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.pbModificar = new System.Windows.Forms.PictureBox();
            this.gpbDomicilio.SuspendLayout();
            this.gpbDatosContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampoIncompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(28, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE(S)";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalle.Location = new System.Drawing.Point(17, 41);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(60, 22);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "CALLE";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(17, 47);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(90, 22);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(28, 195);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(28, 156);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(40, 22);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(28, 120);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(120, 22);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "APELLIDO(S)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 28);
            this.lblTitulo.TabIndex = 7;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoPostal.Location = new System.Drawing.Point(17, 148);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(30, 22);
            this.lblCodigoPostal.TabIndex = 8;
            this.lblCodigoPostal.Text = "CP";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.Location = new System.Drawing.Point(17, 77);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(100, 22);
            this.lblProvincia.TabIndex = 9;
            this.lblProvincia.Text = "PROVINCIA";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCiudad.Location = new System.Drawing.Point(17, 112);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(70, 22);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "CIUDAD";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.Location = new System.Drawing.Point(266, 41);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 22);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "ALTURA";
            // 
            // gpbDomicilio
            // 
            this.gpbDomicilio.Controls.Add(this.txtAltura);
            this.gpbDomicilio.Controls.Add(this.lblCalle);
            this.gpbDomicilio.Controls.Add(this.lblAltura);
            this.gpbDomicilio.Controls.Add(this.txtCalle);
            this.gpbDomicilio.Controls.Add(this.txtProvincia);
            this.gpbDomicilio.Controls.Add(this.txtCiudad);
            this.gpbDomicilio.Controls.Add(this.txtCodigoPostal);
            this.gpbDomicilio.Controls.Add(this.lblCodigoPostal);
            this.gpbDomicilio.Controls.Add(this.lblCiudad);
            this.gpbDomicilio.Controls.Add(this.lblProvincia);
            this.gpbDomicilio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbDomicilio.Location = new System.Drawing.Point(405, 69);
            this.gpbDomicilio.Name = "gpbDomicilio";
            this.gpbDomicilio.Size = new System.Drawing.Size(419, 197);
            this.gpbDomicilio.TabIndex = 7;
            this.gpbDomicilio.TabStop = false;
            this.gpbDomicilio.Text = "DOMICILIO";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(342, 38);
            this.txtAltura.MaxLength = 5;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(67, 30);
            this.txtAltura.TabIndex = 10;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(83, 38);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(177, 30);
            this.txtCalle.TabIndex = 9;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(125, 74);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(230, 30);
            this.txtProvincia.TabIndex = 11;
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(125, 109);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(230, 30);
            this.txtCiudad.TabIndex = 12;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(125, 145);
            this.txtCodigoPostal.MaxLength = 4;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(230, 30);
            this.txtCodigoPostal.TabIndex = 13;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // gpbDatosContacto
            // 
            this.gpbDatosContacto.Controls.Add(this.txtTelefono);
            this.gpbDatosContacto.Controls.Add(this.lblEMail);
            this.gpbDatosContacto.Controls.Add(this.txtEMail);
            this.gpbDatosContacto.Controls.Add(this.lblTelefono);
            this.gpbDatosContacto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbDatosContacto.Location = new System.Drawing.Point(28, 357);
            this.gpbDatosContacto.Name = "gpbDatosContacto";
            this.gpbDatosContacto.Size = new System.Drawing.Size(360, 128);
            this.gpbDatosContacto.TabIndex = 6;
            this.gpbDatosContacto.TabStop = false;
            this.gpbDatosContacto.Text = "DATOS DE CONTACTO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 44);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(237, 30);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEMail.Location = new System.Drawing.Point(17, 85);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(70, 22);
            this.lblEMail.TabIndex = 4;
            this.lblEMail.Text = "E-MAIL";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(113, 82);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(237, 30);
            this.txtEMail.TabIndex = 8;
            this.txtEMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEMail_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(154, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(154, 153);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(224, 30);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(154, 117);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 30);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(241, 189);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(137, 30);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 6, 4, 0, 0, 0, 0);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(28, 228);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(70, 22);
            this.lblGenero.TabIndex = 23;
            this.lblGenero.Text = "GENERO";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.IntegralHeight = false;
            this.cmbGenero.Location = new System.Drawing.Point(154, 225);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(224, 30);
            this.cmbGenero.TabIndex = 4;
            // 
            // pbLimpiar
            // 
            this.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pbLimpiar.Image")));
            this.pbLimpiar.Location = new System.Drawing.Point(417, 384);
            this.pbLimpiar.Name = "pbLimpiar";
            this.pbLimpiar.Size = new System.Drawing.Size(125, 125);
            this.pbLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLimpiar.TabIndex = 24;
            this.pbLimpiar.TabStop = false;
            this.pbLimpiar.Click += new System.EventHandler(this.pbLimpiar_Click);
            // 
            // pbConfirmar
            // 
            this.pbConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("pbConfirmar.Image")));
            this.pbConfirmar.Location = new System.Drawing.Point(552, 384);
            this.pbConfirmar.Name = "pbConfirmar";
            this.pbConfirmar.Size = new System.Drawing.Size(125, 125);
            this.pbConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmar.TabIndex = 25;
            this.pbConfirmar.TabStop = false;
            this.pbConfirmar.Click += new System.EventHandler(this.pbConfirmar_Click);
            // 
            // pbCancelar
            // 
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelar.Image")));
            this.pbCancelar.Location = new System.Drawing.Point(687, 384);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(125, 125);
            this.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCancelar.TabIndex = 26;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // epCampoIncompleto
            // 
            this.epCampoIncompleto.ContainerControl = this;
            // 
            // lblTipoEstudiante
            // 
            this.lblTipoEstudiante.AutoSize = true;
            this.lblTipoEstudiante.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoEstudiante.Location = new System.Drawing.Point(28, 264);
            this.lblTipoEstudiante.Name = "lblTipoEstudiante";
            this.lblTipoEstudiante.Size = new System.Drawing.Size(190, 22);
            this.lblTipoEstudiante.TabIndex = 27;
            this.lblTipoEstudiante.Text = "TIPO DE ESTUDIANTE";
            // 
            // cmbTipoEstudiante
            // 
            this.cmbTipoEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudiante.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoEstudiante.FormattingEnabled = true;
            this.cmbTipoEstudiante.IntegralHeight = false;
            this.cmbTipoEstudiante.Location = new System.Drawing.Point(224, 261);
            this.cmbTipoEstudiante.Name = "cmbTipoEstudiante";
            this.cmbTipoEstudiante.Size = new System.Drawing.Size(154, 30);
            this.cmbTipoEstudiante.TabIndex = 5;
            this.cmbTipoEstudiante.TextChanged += new System.EventHandler(this.cmbTipoEstudiante_TextChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNivel.Location = new System.Drawing.Point(28, 300);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(60, 22);
            this.lblNivel.TabIndex = 29;
            this.lblNivel.Text = "NIVEL";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(154, 297);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(224, 30);
            this.cmbNivel.TabIndex = 6;
            // 
            // pbModificar
            // 
            this.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbModificar.Image = ((System.Drawing.Image)(resources.GetObject("pbModificar.Image")));
            this.pbModificar.Location = new System.Drawing.Point(552, 384);
            this.pbModificar.Name = "pbModificar";
            this.pbModificar.Size = new System.Drawing.Size(125, 125);
            this.pbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModificar.TabIndex = 30;
            this.pbModificar.TabStop = false;
            this.pbModificar.Click += new System.EventHandler(this.pbModificar_Click);
            // 
            // FrmAltaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 521);
            this.Controls.Add(this.pbModificar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cmbTipoEstudiante);
            this.Controls.Add(this.lblTipoEstudiante);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.pbConfirmar);
            this.Controls.Add(this.pbLimpiar);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gpbDatosContacto);
            this.Controls.Add(this.gpbDomicilio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaModificacion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmAltaModificacion";
            this.Load += new System.EventHandler(this.FrmAltaModificacion_Load);
            this.gpbDomicilio.ResumeLayout(false);
            this.gpbDomicilio.PerformLayout();
            this.gpbDatosContacto.ResumeLayout(false);
            this.gpbDatosContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCampoIncompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.GroupBox gpbDomicilio;
        private System.Windows.Forms.GroupBox gpbDatosContacto;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.PictureBox pbLimpiar;
        private System.Windows.Forms.PictureBox pbConfirmar;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.ErrorProvider epCampoIncompleto;
        private System.Windows.Forms.ComboBox cmbTipoEstudiante;
        private System.Windows.Forms.Label lblTipoEstudiante;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.PictureBox pbModificar;
    }
}