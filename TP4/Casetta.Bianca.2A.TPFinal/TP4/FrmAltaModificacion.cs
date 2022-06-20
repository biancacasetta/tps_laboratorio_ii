using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP4
{
    public partial class FrmAltaModificacion : Form
    {
        private Instituto instituto;
        private Estudiante estudiante;

        public FrmAltaModificacion(Instituto instituto) : this(instituto, null)
        {

        }
        public FrmAltaModificacion(Instituto instituto, Estudiante estudiante)
        {
            InitializeComponent();
            this.instituto = instituto;
            this.estudiante = estudiante;
        }

        /// <summary>
        /// Propiedad de lectura-escritura para la propiedad Text del control de lblTitulo
        /// </summary>
        public string Titulo
        {
            get
            {
                return this.lblTitulo.Text;
            }
            set
            {
                this.lblTitulo.Text = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el control de pbConfirmar
        /// </summary>
        public PictureBox BotonConfirmar
        {
            get
            {
                return this.pbConfirmar;
            }
            set
            {
                this.pbConfirmar = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el control de pbModificar
        /// </summary>
        public PictureBox BotonModificar
        {
            get
            {
                return this.pbModificar;
            }
            set
            {
                this.pbModificar = value;
            }
        }

        /// <summary>
        /// Inicializa el cmbGenero, cmbTipoEstudiante y cmbNivel de FrmAltaModificacion.
        /// En caso de ser una Modificacion, se cargan los datos del Estudiante a modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("No Binario");
            cmbGenero.SelectedIndex = 0;

            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            // Carga
            cmbTipoEstudiante.DataSource = Enum.GetValues(typeof(ETipoEstudiante));
            // Lectura
            ETipoEstudiante tipos;
            Enum.TryParse<ETipoEstudiante>(cmbTipoEstudiante.SelectedValue.ToString(), out tipos);

            // Carga
            cmbNivel.DataSource = Enum.GetValues(typeof(ENivel));
            // Lectura
            ENivel niveles;
            Enum.TryParse<ENivel>(cmbNivel.SelectedValue.ToString(), out niveles);

            CargarDatosEstudianteParaModificar(this.estudiante);

        }

        /// <summary>
        /// Se vacian todos los campos de texto del FrmAltaModificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtDni.Text = String.Empty;
            dtpFechaNacimiento.Text = DateTime.Now.ToShortDateString();
            cmbGenero.SelectedIndex = 0;
            cmbTipoEstudiante.SelectedIndex = 0;
            cmbNivel.SelectedIndex = 0;
            txtTelefono.Text = String.Empty;
            txtEMail.Text = String.Empty;
            txtCalle.Text = String.Empty;
            txtAltura.Text = String.Empty;
            txtProvincia.Text = String.Empty;
            txtCiudad.Text = String.Empty;
            txtCodigoPostal.Text = String.Empty;
        }

        /// <summary>
        /// En el formulario de Alta, al presionar Confirmar se verifica si se dejo algun campo vacio o si ya existe el Estudiante ingresado.
        /// Si se da de alta con exito, se serializan los datos y se crea o sobreescribe el archivo .xml con el listado de Estudiantes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCamposVacios();
                Estudiante aux = null;
                Domicilio dom = new Domicilio(txtCalle.Text, int.Parse(txtAltura.Text), txtCiudad.Text, txtProvincia.Text, int.Parse(txtCodigoPostal.Text));
                switch(cmbTipoEstudiante.Text)
                {
                    case "Particular":
                        aux = new EstudianteParticular(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), dtpFechaNacimiento.Value, cmbGenero.Text,
                            double.Parse(txtTelefono.Text), dom, ETipoEstudiante.Particular, txtEMail.Text);
                        break;
                    case "Curso":
                        Curso curso = new Curso(Enum.Parse<ENivel>(cmbNivel.Text));
                        aux = new EstudianteCurso(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), dtpFechaNacimiento.Value, cmbGenero.Text,
                            double.Parse(txtTelefono.Text), dom, ETipoEstudiante.Curso, txtEMail.Text, curso);
                        break;
                    case "Externo":
                        ENivel nivel = Enum.Parse<ENivel>(cmbNivel.Text);
                        aux = new EstudianteExterno(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), dtpFechaNacimiento.Value, cmbGenero.Text,
                            double.Parse(txtTelefono.Text), dom, ETipoEstudiante.Externo, nivel, txtEMail.Text);
                        break;
                }

                if (instituto != aux)
                {
                    instituto.Estudiantes.Add(aux);
                    MessageBox.Show($"Se dio de alta a {this.txtNombre.Text} {this.txtApellido.Text}", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Serializer<List<Estudiante>>.SerializarXml(instituto.Estudiantes);
                    if(aux is EstudianteCurso)
                    {
                        BaseDeDatos.Alta((EstudianteCurso)aux);
                    }

                    pbLimpiar_Click(sender, e);
                }
                else
                {
                    throw new EstudianteYaExistenteException($"Ya existe un estudiante bajo el DNI {txtDni.Text}");
                }
            }
            catch (CamposIncompletosException ex)
            {
                MessageBox.Show(ex.Message, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EstudianteYaExistenteException ex)
            {
                MessageBox.Show(ex.Message, "Estudiante ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al dar de alta", "Alta no efectuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se cierra el Form si despues de la advertencia se selecciona Si
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult respuesta = MessageBox.Show("¿Está seguro de querer cancelar la operación?", "Cancelar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Se habilita o bloquea el cmbNivel segun el tipo de Estudiante seleccionado en el campo anterior.
        /// Los EstudianteParticular no tienen Nivel porque es personalizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (cmbTipoEstudiante.Text == "Particular")
            {
                cmbNivel.Enabled = false;
            }
            else
            {
                cmbNivel.Enabled = true;
            }
        }

        /// <summary>
        /// Cuando se instancia el form para Modificar, se cargan los datos del Estudiante en los textBox modificables
        /// </summary>
        /// <param name="estudiante">El Estudiante a cargar</param>
        private void CargarDatosEstudianteParaModificar(Estudiante estudiante)
        {
            if (estudiante is not null)
            {
                txtNombre.Text = estudiante.Nombre;
                txtApellido.Text = estudiante.Apellido;
                txtDni.Text = estudiante.Dni.ToString();
                txtDni.ReadOnly = true;
                dtpFechaNacimiento.Value = estudiante.FechaDeNacimiento;
                cmbGenero.Text = estudiante.Genero;
                cmbTipoEstudiante.Text = estudiante.TipoEstudiante.ToString();
                if (cmbTipoEstudiante.Text != "Particular")
                {
                    if (estudiante is EstudianteCurso)
                    {
                        cmbNivel.Text = ((EstudianteCurso)estudiante).Curso.Nivel.ToString();
                    }
                    else
                    {
                        cmbNivel.Text = ((EstudianteExterno)estudiante).Nivel.ToString();
                    }
                }
                else
                {
                    cmbNivel.Enabled = false;
                }
                txtTelefono.Text = estudiante.Telefono.ToString();
                txtEMail.Text = estudiante.EMail;
                txtCalle.Text = estudiante.Domicilio.Calle;
                txtAltura.Text = estudiante.Domicilio.Altura.ToString();
                txtProvincia.Text = estudiante.Domicilio.Provincia;
                txtCiudad.Text = estudiante.Domicilio.Ciudad;
                txtCodigoPostal.Text = estudiante.Domicilio.CodigoPostal.ToString();
            }
               
        }

        /// <summary>
        /// Se reasignan los datos en caso de modificarlos
        /// </summary>
        /// <param name="estudiante">Estudiante cuyos datos se van a actualizar</param>
        /// <returns>El Estudiante actualizado</returns>
        private Estudiante ActualizarDatos(Estudiante estudiante)
        {
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Dni = int.Parse(txtDni.Text);
            estudiante.FechaDeNacimiento = dtpFechaNacimiento.Value;
            estudiante.Genero = cmbGenero.Text;
            estudiante.TipoEstudiante = Enum.Parse<ETipoEstudiante>(cmbTipoEstudiante.Text);
             
            if(estudiante is EstudianteCurso)
            {
                ((EstudianteCurso)estudiante).Curso.Nivel = Enum.Parse<ENivel>(cmbNivel.Text);
            }
            else if(estudiante is EstudianteExterno)
            {
                ((EstudianteExterno)estudiante).Nivel = Enum.Parse<ENivel>(cmbNivel.Text);
            }
            
            estudiante.Telefono = double.Parse(txtTelefono.Text);
            estudiante.EMail = txtEMail.Text;
            estudiante.Domicilio.Calle = txtCalle.Text;
            estudiante.Domicilio.Altura = int.Parse(txtAltura.Text);
            estudiante.Domicilio.Provincia = txtProvincia.Text;
            estudiante.Domicilio.Ciudad = txtCiudad.Text;
            estudiante.Domicilio.CodigoPostal = int.Parse(txtCodigoPostal.Text);

            return estudiante;
        }

        /// <summary>
        /// Acciones a realizar al hacer click en pbModificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarCamposVacios();
                Estudiante estudianteModificado = this.ActualizarDatos(this.estudiante);
                int indiceDelModificado = instituto.Estudiantes.IndexOf(this.estudiante);
                instituto.Estudiantes[indiceDelModificado] = estudianteModificado;
                Serializer<List<Estudiante>>.SerializarXml(instituto.Estudiantes);
                if(estudianteModificado is EstudianteCurso)
                {
                    ((EstudianteCurso)estudianteModificado).Actualizar(estudianteModificado.Dni);
                }
                MessageBox.Show($"Se modificó a {this.estudiante.Nombre} {this.estudiante.Apellido}", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(CamposIncompletosException ex)
            {
                MessageBox.Show(ex.Message, "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al modificar al estudiante", "Modificación no efectuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validacion de campos tipo string para que solo ingresen letras o espacios o borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !Char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se pueden ingresar letras", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validacion de campos tipo int/double para que solo ingresen numeros o borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar números", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Validacion del campo txtEMail para que solo ingresen letras, numeros, guiones bajos, arrobas o puntos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)64 && e.KeyChar != (char)46 && e.KeyChar != (char)95)
            {
                MessageBox.Show("Solo se pueden ingresar letras, números, @, . y _", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Valida que ningun campo del formulario de Alta quede vacio. Todos son obligatorios.
        /// </summary>
        private void ValidarCamposVacios()
        {
            if (txtNombre.Text == String.Empty ||
            txtApellido.Text == String.Empty ||
            txtDni.Text == String.Empty ||
            txtTelefono.Text == String.Empty ||
            txtEMail.Text == String.Empty ||
            txtCalle.Text == String.Empty ||
            txtAltura.Text == String.Empty ||
            txtProvincia.Text == String.Empty ||
            txtCiudad.Text == String.Empty ||
            txtCodigoPostal.Text == String.Empty)
            {
                throw new CamposIncompletosException("Hay campos incompletos. Todos los campos son obligatorios.");
            }
        }
            
    }
}
