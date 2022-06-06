using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP3
{
    public partial class FrmListadoEstudiantes : Form
    {
        private Instituto instituto;

        public FrmListadoEstudiantes(Instituto instituto)
        {
            InitializeComponent();
            this.instituto = instituto;
        }

        /// <summary>
        /// Se inicializa el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListadoEstudiantes_Load(object sender, EventArgs e)
        {
            rtbListado.Text = instituto.ToString();
        }

        /// <summary>
        /// Se busca un Estudiante y si existe, se muestra su ficha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == String.Empty)
            {
                MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Estudiante estudiante = instituto.BuscarEstudiantePorDni(int.Parse(txtDni.Text));
                if (estudiante is not null)
                {
                    FrmFicha frmFicha = new FrmFicha(instituto, estudiante);
                    frmFicha.BotonEliminar.Visible = false;
                    frmFicha.BotonCancelar.Visible = false;
                    frmFicha.BotonVolver.Visible = true;
                    frmFicha.ShowDialog();
                }
                else
                {
                    MessageBox.Show("DNI inexistente", "Estudiante no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        /// <summary>
        /// Valida si las teclas ingresadas son solo numeros o borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se pueden ingresar números", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
