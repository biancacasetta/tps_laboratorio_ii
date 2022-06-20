using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FrmBibliografia : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken token;

        public FrmBibliografia()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;
        }

        /// <summary>
        /// Lee el archivo de extension .txt para mostrar la bibliografía de los cursos en un RichTextBox.
        /// Inicializa un subproceso en el que se muestran las portadas de los libros de texto utilizados en dicha bibliografía.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBibliografia_Load(object sender, EventArgs e)
        {
            rtbBibliografia.Text = Serializer<string>.LeerTxt();
            Task tarea = Task.Run(() => IniciarRotacion(cancellationTokenSource), token);
        }

        /// <summary>
        /// Se itera las imágenes del ImageList para mostrarlas en bucle mientras esté abierto el FrmBibliografia 
        /// </summary>
        /// <param name="cts">Token para cerrar el hilo al cerrar el Form</param>
        private void IniciarRotacion(CancellationTokenSource cts)
        {
            int indice = 0;
            do
            {
                RotarPortadas(indice);
                Thread.Sleep(2000);
                indice++;

                if (indice == 6)
                {
                    indice = 0;
                }

            } while (!cts.IsCancellationRequested);
        }

        /// <summary>
        /// Se invoca a la referencia del método de manera recursiva para que trabaje en un hilo secundario.
        /// Se reasigna el valor del indice de la ImageList.
        /// </summary>
        /// <param name="indice">Indice de la ImageList que se va mostrando</param>
        private void RotarPortadas(int indice)
        {
            if(InvokeRequired)
            {
                Action<int> callback = RotarPortadas;
                this.Invoke(callback, indice);
            }
            else
            {
                lblPortadas.ImageIndex = indice;
            }
        }
    }
}
