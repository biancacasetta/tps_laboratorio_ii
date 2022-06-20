using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FrmFicha : Form
    {
        private Instituto instituto;
        private Estudiante estudiante;
        public FrmFicha(Instituto instituto, Estudiante estudiante)
        {
            InitializeComponent();
            this.instituto = instituto;
            this.estudiante = estudiante;
        }

        /// <summary>
        /// Se cargan todos los campos de tipo Label con la informacion del Estudiante instanciado por constructor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFicha_Load(object sender, EventArgs e)
        {
            MostrarEstudiante();
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el control de pbEliminar
        /// </summary>
        public PictureBox BotonEliminar
        {
            get
            {
                return this.pbEliminar;
            }
            set
            {
                this.pbEliminar = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el control de pbVolver
        /// </summary>
        public PictureBox BotonVolver
        {
            get
            {
                return this.pbVolver;
            }
            set
            {
                this.pbVolver = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el control de pbCancelar
        /// </summary>
        public PictureBox BotonCancelar
        {
            get
            {
                return this.pbCancelar;
            }
            set
            {
                this.pbCancelar = value;
            }
        }

        /// <summary>
        /// Muestra un estudiante con Labels, solo para ver la informacion. No se interactua con ningun campo.
        /// </summary>
        private void MostrarEstudiante()
        {
            lblNombreInfo.Text = estudiante.Nombre;
            lblApellidoInfo.Text = estudiante.Apellido;
            lblDniInfo.Text = estudiante.Dni.ToString();
            lblFechaNacimientoInfo.Text = String.Format($"{estudiante.FechaDeNacimiento.ToShortDateString():dd/MM/yyyy}");
            lblEdadInfo.Text = ((DateTime.Now.Subtract(estudiante.FechaDeNacimiento)).Days / 365).ToString();
            lblGeneroInfo.Text = estudiante.Genero;
            lblTipoEstudianteInfo.Text = estudiante.TipoEstudiante.ToString();
            if (lblTipoEstudianteInfo.Text != "Particular")
            {
                if (estudiante is EstudianteCurso)
                {
                    lblNivelInfo.Text = ((EstudianteCurso)estudiante).Curso.Nivel.ToString();
                }
                else
                {
                    lblNivelInfo.Text = ((EstudianteExterno)estudiante).Nivel.ToString();
                }
            }
            else
            {
                lblNivel.Visible = false;
                lblNivelInfo.Visible = false;
            }
            lblTelefonoInfo.Text = estudiante.Telefono.ToString();
            lblEMailInfo.Text = estudiante.EMail;
            lblCalleInfo.Text = estudiante.Domicilio.Calle;
            lblAlturaInfo.Text = estudiante.Domicilio.Altura.ToString();
            lblProvinciaInfo.Text = estudiante.Domicilio.Provincia;
            lblCiudadInfo.Text = estudiante.Domicilio.Ciudad;
            lblCodigoPostalInfo.Text = estudiante.Domicilio.CodigoPostal.ToString();
        }

        /// <summary>
        /// Se cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Se elimina un Estudiante permanentemente, si se confirma la baja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show($"¿Está seguro de querer eliminar a {this.estudiante.Nombre} {this.estudiante.Apellido}?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rta == DialogResult.Yes)
            {
                try
                { 
                    MessageBox.Show($"Se eliminó a {this.estudiante.Nombre} {this.estudiante.Apellido}", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    instituto.Estudiantes.Remove(this.estudiante);
                    Serializer<List<Estudiante>>.SerializarXml(instituto.Estudiantes);
                    if(this.estudiante is EstudianteCurso)
                    {
                        estudiante.Dni.Baja();
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema al dar de baja", "Baja no efectuada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// Se cierra el form pero luego de poder ver la informacion del Estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
