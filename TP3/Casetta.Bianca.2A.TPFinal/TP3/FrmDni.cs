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

namespace TP3
{
    public partial class FrmDni : Form
    {
        private Instituto instituto;
        private string accion;
        public FrmDni(Instituto instituto, string accion)
        {
            InitializeComponent();
            this.instituto = instituto;
            this.accion = accion;
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
            Estudiante estudiante = null;

            if (txtDni.Text == String.Empty)
            {
                MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (this.accion)
                {
                    case "Baja":
                        estudiante = instituto.BuscarEstudiantePorDni(int.Parse(txtDni.Text));
                        if (estudiante is not null)
                        {
                            FrmFicha frmFicha = new FrmFicha(instituto, estudiante);
                            frmFicha.BotonEliminar.Visible = true;
                            frmFicha.BotonCancelar.Visible = true;
                            frmFicha.BotonVolver.Visible = false;
                            frmFicha.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Modificar":
                        estudiante = instituto.BuscarEstudiantePorDni(int.Parse(txtDni.Text));
                        if (estudiante is not null)
                        {
                            FrmAltaModificacion frmModificacion = new FrmAltaModificacion(instituto, estudiante);
                            frmModificacion.Titulo = "MODIFICAR ESTUDIANTE";
                            frmModificacion.StartPosition = FormStartPosition.CenterScreen;
                            frmModificacion.BotonConfirmar.Visible = false;
                            frmModificacion.BotonModificar.Visible = true;
                            frmModificacion.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
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
    }
}
