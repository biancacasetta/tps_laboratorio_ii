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
    public partial class FrmCursos : Form, ISubForm
    {
        private Form subFormMostrado;
        private Instituto instituto;
        public FrmCursos(Instituto instituto)
        {
            InitializeComponent();
            this.instituto = instituto;
        }

        /// <summary>
        /// A partir de este FrmCursos, se llama a otro Form para abrirlo en el Panel correspondiente
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
            pnlCuerpo.Controls.Clear();
            pnlCuerpo.Controls.Add(subForm);
            subForm.BringToFront();
            subForm.Show();
        }

        /// <summary>
        /// Se llama a FrmInfoCursos a partir de un click en pbInformacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbInformacion_Click(object sender, EventArgs e)
        {
            FrmInfoCursos frmInfo = new FrmInfoCursos(instituto);
           ((ISubForm)this).AbrirSubForm(frmInfo, pnlCuerpo);
        }

        /// <summary>
        /// Se llama a FrmBibliografia a partir de un click en pbBibliografia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBibliografia_Click(object sender, EventArgs e)
        {
            FrmBibliografia frmBiblio = new FrmBibliografia();
            ((ISubForm)this).AbrirSubForm(frmBiblio, pnlCuerpo);
        }
    }
}
