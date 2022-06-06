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
    public partial class FrmHome : Form, ISubForm
    {
        private Form subFormMostrado;
        private Instituto instituto;
        private string path = "listadoEstudiantes.xml";

        public FrmHome()
        {
            InitializeComponent();
            instituto = new Instituto();
        }

        /// <summary>
        /// A partir de este FrmHome, se llama a otro Form para abrirlo en el Panel correspondiente
        /// </summary>
        /// <param name="subForm"></param>
        /// <param name="panel"></param>
        void ISubForm.AbrirSubForm(Form subForm, Panel panel)
        {
            if(subFormMostrado is not null)
            {
                subFormMostrado.Close();
            }

            subFormMostrado = subForm;
            subForm.TopLevel = false;
            subFormMostrado.Dock = DockStyle.Fill;
            panel.Controls.Add(subForm);
            subForm.BringToFront();
            subForm.Show();
        }

        /// <summary>
        /// Se abre un FrmEstudiante al hacer click en Estudiantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frmEstudiantes = new FrmEstudiantes(instituto);
            pnlMenuVertical.Visible = true;
            ((ISubForm)this).AbrirSubForm(frmEstudiantes, pnlMenuVertical);
        }

        /// <summary>
        /// Se abre un FrmCursos al hacer click en Cursos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCursos_Click(object sender, EventArgs e)
        {
            FrmCursos frmCursos = new FrmCursos(instituto);
            pnlMenuVertical.Visible = true;
            ((ISubForm)this).AbrirSubForm(frmCursos, pnlMenuVertical);
        }

        /// <summary>
        /// Se reinicia el estado del Form a como cuando apenas se ejecuta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLogoEcoCenter_Click(object sender, EventArgs e)
        {
            pnlMenuVertical.Visible = false;
        }

        /// <summary>
        /// Se cierra todo el programa, luego de confirmar la salida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Se reconfirma la salida antes de cerrar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if(rta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Se incializa el Form deserializando el archivo .xml si es que existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHome_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    instituto.Estudiantes = Serializer<List<Estudiante>>.DeserializarXml();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al cargar el listado de estudiantes", "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
