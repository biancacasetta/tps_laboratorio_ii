using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
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
        /// Segun la opcion seleccionada en el cmbCursos, se muestra la informacion del curso seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCursos_TextChanged(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = cmbCursos.Text.LeerPorNivel();
        }

        /// <summary>
        /// Formatea las celdas a mostrar en el DataGridView dgvCursos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvCursos.Rows[e.RowIndex].DataBoundItem != null) && (dgvCursos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = AsociarPropiedad(
                 dgvCursos.Rows[e.RowIndex].DataBoundItem,
                 dgvCursos.Columns[e.ColumnIndex].DataPropertyName
               );

            }
        }

        /// <summary>
        /// En los casos en los que la propiedad a mostrar esta anidada
        /// (por ejemplo para recuperar el Docente desde un objeto EstudianteCurso, se hace desde estudiante.Curso.Docente)
        /// primero se obtiene la propiedad padre al dividir la string hasta donde haya un punto '.'
        /// y a partir de eso se obtiene el tipo y valor de las propiedades anidadas volviendo a llamar recursivamente al método.
        /// </summary>
        /// <param name="propiedad">Propiedad que contiene otras propiedades anidadas</param>
        /// <param name="nombrePropiedad">El nombre de la propiedad (Curso)</param>
        /// <returns></returns>
        private string AsociarPropiedad(object propiedad, string nombrePropiedad)
        {
            string retorno = "";

            if (nombrePropiedad.Contains("."))
            {
                PropertyInfo[] propiedades;
                string nombrePropiedadPadre;

                nombrePropiedadPadre = nombrePropiedad.Substring(0, nombrePropiedad.IndexOf("."));
                propiedades = propiedad.GetType().GetProperties();

                foreach (PropertyInfo infoPropiedad in propiedades)
                {
                    if (infoPropiedad.Name == nombrePropiedadPadre)
                    {
                        retorno = AsociarPropiedad(
                        infoPropiedad.GetValue(propiedad),
                        nombrePropiedad.Substring(nombrePropiedad.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type tipoPropiedad;
                PropertyInfo infoPropiedad;

                tipoPropiedad = propiedad.GetType();
                infoPropiedad = tipoPropiedad.GetProperty(nombrePropiedad);
                retorno = infoPropiedad.GetValue(propiedad).ToString();
            }

            return retorno;
        }
    }
}
