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
    public partial class FrmInfoCursos : Form
    {
        private Instituto instituto;

        public FrmInfoCursos(Instituto instituto)
        {
            InitializeComponent();
            this.instituto = instituto;
        }
        /// <summary>
        /// Se inicializa el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoCursos_Load(object sender, EventArgs e)
        {
            // Carga
            cmbCursos.DataSource = Enum.GetValues(typeof(ENivel));
            // Lectura
            ENivel niveles;
            Enum.TryParse<ENivel>(cmbCursos.SelectedValue.ToString(), out niveles);
        }

        /// <summary>
        /// Se instancia un curso segun el nivel que corresponda
        /// </summary>
        /// <param name="nivel"></param>
        /// <returns></returns>
        private string InstanciarCurso(ENivel nivel)
        {
            Curso curso = new Curso(nivel, instituto);

            return curso.ToString();
        }

        /// <summary>
        /// Segun la opcion seleccionada en el cmbCursos, se muestra la informacion del curso seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCursos_TextChanged(object sender, EventArgs e)
        {

            switch(cmbCursos.Text)
            {
                case "Primer_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
                case "Segundo_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
                case "Tercer_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
                case "Cuarto_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
                case "Quinto_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
                case "Sexto_Año":
                    rtbInfoCurso.Text = InstanciarCurso(Enum.Parse<ENivel>(cmbCursos.Text));
                    break;
            }
        }

        /// <summary>
        /// Se crea un archivo .json con los datos de los cursos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbExportar_Click(object sender, EventArgs e)
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                for (int i = 0; i < cmbCursos.Items.Count; i++)
                {
                    Curso curso = new Curso((ENivel)i, instituto);
                    cursos.Add(curso);
                }

                Serializer<List<Curso>>.SerializarJson(cursos);

                MessageBox.Show(@"Se creó un archivo .json con los datos de los cursos dentro de este proyecto en \Casetta.Bianca.2A.TPFinal\TP3\bin\Debug\net5.0-windows\",
                    "Arhivo JSON creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al exportar el archivo", "Error al exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
