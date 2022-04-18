using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Limpia los campos de los operandos 1 y 2, la selección de operador en el ComboBox y la label del resultado se reestablece a 0
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// Realiza la operación entre los dos opoerandos ingresados por el usuario en el form según el operador indicado
        /// </summary>
        /// <param name="numero1">Primero operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operación a realizar con los operandos</param>
        /// <returns>El resultado de tipo double de la operación</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            double resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        /// <summary>
        /// Carga las opciones predeterminadas del ComboBox de operadores
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();

            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
        }

        /// <summary>
        /// Llama al método Limpiar() al hacer click sobre el botón del mismo nombre
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Valida que los datos ingresados por el usuario sean válidos para operar. Si es así, llama a Operar() y realiza la operación, que luego la muestra en el ListBox del historial de operaciones
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }

            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || !double.TryParse(txtNumero1.Text, out _))
            {
                txtNumero1.Text = "0";
            }

            if (string.IsNullOrWhiteSpace(txtNumero2.Text) || !double.TryParse(txtNumero2.Text, out _))
            {
                txtNumero2.Text = "0";
            }

            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

            if(lblResultado.Text == double.MinValue.ToString())
            {
                lblResultado.Text = "Error al dividir por 0";
            }

            lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
        }

        /// <summary>
        /// Se incializa el cierre del form, que en este caso pasa por el evento FormClosing antes de completarse
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al apretar el botón Cerrar o la cruz del form, se le pregunta al usuario si está seguro de querer salir para que reconfirme la salida
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Llama al método DecimalBinario de la clase Operando para que realice dicha conversión y la muestre por la label del resultado en el form
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Llama al método BinarioDecimal de la clase Operando para que realice dicha conversión y la muestre por la label del resultado en el form
        /// </summary>
        /// <param name="sender">El objeto que generó el evento</param>
        /// <param name="e">Provee información a los métodos que tratan el evento</param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
    }
}
