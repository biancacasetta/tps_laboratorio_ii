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
    public partial class FrmEstudiantes : Form, ISubForm
    {
        private Form subFormMostrado;
        private Instituto instituto;
        public FrmEstudiantes(Instituto instituto)
        {
            InitializeComponent();
            this.instituto = instituto;

        }

        /// <summary>
        /// A partir de este FrmEstudiantes, se llama a otro Form para abrirlo en el Panel correspondiente
        /// </summary>
        /// <param name="subForm"></param>
        /// <param name="panel"></param>
        void ISubForm.AbrirSubForm(Form subForm, Panel panel)
        {
            if (this.subFormMostrado is not null)
            {
                this.subFormMostrado.Close();
            }

            this.subFormMostrado = subForm;
            subForm.TopLevel = false;
            this.subFormMostrado.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(subForm);
            subForm.BringToFront();
            subForm.Show();
        }

        /// <summary>
        /// Se abre el Form de Alta al hacer click en Alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbAlta_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAlta = new FrmAltaModificacion(instituto);
            frmAlta.Titulo = "ALTA DE ESTUDIANTE";
            frmAlta.BotonConfirmar.Visible = true;
            frmAlta.BotonModificar.Visible = false;

            ((ISubForm)this).AbrirSubForm(frmAlta, pnlCuerpo);
        }

        /// <summary>
        /// Se abre el Form de Modificacion al hacer click en Modificacion, si existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbModificacion_Click(object sender, EventArgs e)
        {
            FrmDni frmDni = new FrmDni(instituto, "Modificar");
            frmDni.Titulo = "MODIFICAR ESTUDIANTE";
            ((ISubForm)this).AbrirSubForm(frmDni, pnlCuerpo);
        }

        /// <summary>
        /// Se abre el Form de la ficha de Estudiante a eliminar, si existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBaja_Click(object sender, EventArgs e)
        {
            FrmDni frmDni = new FrmDni(instituto, "Baja");
            frmDni.Titulo = "BAJA DE ESTUDIANTE";
            ((ISubForm)this).AbrirSubForm(frmDni, pnlCuerpo);
        }

        /// <summary>
        /// Se abre el Form de ListadoEstudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbListado_Click(object sender, EventArgs e)
        {
            FrmListadoEstudiantes frmListado = new FrmListadoEstudiantes(instituto);
            ((ISubForm)this).AbrirSubForm(frmListado, pnlCuerpo);
        }
    }
}
