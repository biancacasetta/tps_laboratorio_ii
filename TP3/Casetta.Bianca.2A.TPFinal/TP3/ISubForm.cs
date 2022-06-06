using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public interface ISubForm
    {
        /// <summary>
        /// Metodo de interfaz obligatorio para las clases que la implementan
        /// </summary>
        /// <param name="form">subForm a abrir</param>
        /// <param name="panel">Panel donde se abre el subForm</param>
        void AbrirSubForm(Form form, Panel panel);
    }
}
