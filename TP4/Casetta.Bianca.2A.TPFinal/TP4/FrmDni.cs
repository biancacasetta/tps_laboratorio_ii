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
    public partial class FrmDni : Form
    {
        private Instituto instituto;
        public delegate void DelegadoBaja();
        private DelegadoBaja delegadoBaja;
        public delegate void DelegadoModificar();
        private DelegadoModificar delegadoModificar;
        private Estudiante estudiante;
        public delegate bool ConfirmarDniEncontradoHandler(Estudiante estudiante, Delegate delegado);
        private event ConfirmarDniEncontradoHandler OnBuscarDni;

        public FrmDni(Instituto instituto)
        {
            InitializeComponent();
            this.instituto = instituto;
            delegadoBaja += DarDeBaja;
            delegadoModificar += Modificar;
            this.OnBuscarDni += VerificarDni;
        }

        /// <summary>
        /// Propiedad de lectura-escritura para la propiedad Text del control de Titulo
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
        /// Acciones a realizar al hacer click en Confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbConfirmar_Click(object sender, EventArgs e)
        {

            if (txtDni.Text == String.Empty)
            {
                MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estudiante = instituto.BuscarEstudiantePorDni(int.Parse(txtDni.Text));


                if (this.Titulo == "MODIFICAR ESTUDIANTE")
                {
                    delegadoModificar.Invoke();
                }
                else if(this.Titulo == "BAJA DE ESTUDIANTE")
                {
                    delegadoBaja.Invoke();
                }   
            }  
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
        /// Valida si las teclas ingresadas son solo numeros, borrar o escape/enter para Confirmar o Cancelar respectivamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                pbConfirmar_Click(sender, e);
            }
            else if (e.KeyChar == (char)27)
            {
                pbCancelar_Click(sender, e);
            }
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar números", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Metodo que coincide con la firma del delegado DelegadoBaja, asociado a dicho delegado en el constructor.
        /// Se invoca el DelegadoBaja si este FrmDni se instancio a partir del boton Baja del menú anterior
        /// </summary>
        private void DarDeBaja()
        { 
            if (OnBuscarDni.Invoke(estudiante))
            {
                FrmFicha frmFicha = new FrmFicha(instituto, estudiante);
                frmFicha.BotonEliminar.Visible = true;
                frmFicha.BotonCancelar.Visible = true;
                frmFicha.BotonVolver.Visible = false;
                frmFicha.ShowDialog();
            }

        }

        /// <summary>
        /// Metodo que coincide con la firma del delegado DelegadoModificar, asociado a dicho delegado en el constructor.
        /// Se invoca el DelegadoModificar si este FrmDni se instancio a partir del boton Modificacion del menú anterior
        /// </summary>
        private void Modificar()
        {
            if (OnBuscarDni.Invoke(estudiante))
            {
                FrmAltaModificacion frmModificacion = new FrmAltaModificacion(instituto, estudiante);
                frmModificacion.Titulo = "MODIFICAR ESTUDIANTE";
                frmModificacion.StartPosition = FormStartPosition.CenterScreen;
                frmModificacion.BotonConfirmar.Visible = false;
                frmModificacion.BotonModificar.Visible = true;
                frmModificacion.ShowDialog();
            }
        }

        /// <summary>
        /// Verifica que el DNI ingresado tanto para dar de baja como para modificar exista y en tal caso se informa con un MessageBox
        /// </summary>
        /// <param name="estudiante">El estudiante cuyo DNI se verifica</param>
        /// <returns>Un booleano indicando si existe el DNI</returns>
        private bool VerificarDni(Estudiante estudiante)
        {
            bool estudianteVerificado = false;

            if(estudiante is not null)
            {
                MessageBox.Show("Se ha encontrado el DNI en la base de datos.", "Estudiante encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estudianteVerificado = true;
            }
            else
            {
                MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estudianteVerificado;
        }
    }
}
