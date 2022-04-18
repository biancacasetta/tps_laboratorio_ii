using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Propiedad de la clase Operando que asigna el valor del atributo numero, con previa validación del valor a asignar
        /// </summary>
        private string Numero
        {
            set { numero = Operando.ValidarOperando(value); }
        }

        /// <summary>
        /// Constructor sin parámetros que setea el atributo numero en 0 por default
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que setea un double al atributo numero
        /// </summary>
        /// <param name="numero">Valor de tipo double para asignar al crear un objeto de clase Operando</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que setea una string a la propiedad Numero
        /// </summary>
        /// <param name="strNumero">Cadena a asignar a la propiedad Numero al crear un objeto de clase Operando</param>
        public Operando(string strNumero)
        {   
            Numero = strNumero;
        }

        /// <summary>
        /// Sobrecarga del operador + para poder sumar los atributos numero de dos objetos de clase Operando
        /// </summary>
        /// <param name="n1">Primer objeto de clase Operando</param>
        /// <param name="n2">Segundo objeto de clase Operando</param>
        /// <returns>El resultado de la operación</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador - para poder restar los atributos numero de dos objetos de clase Operando
        /// </summary>
        /// <param name="n1">Primer objeto de clase Operando</param>
        /// <param name="n2">Segundo objeto de clase Operando</param>
        /// <returns>El resultado de la operación</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * para poder multiplicar los atributos numero de dos objetos de clase Operando
        /// </summary>
        /// <param name="n1">Primer objeto de clase Operando</param>
        /// <param name="n2">Segundo objeto de clase Operando</param>
        /// <returns>El resultado de la operación</returns>
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / para poder dividir los atributos numero de dos objetos de clase Operando. En caso de división por 0, retorna double.MinValue
        /// </summary>
        /// <param name="n1">Primer objeto de clase Operando</param>
        /// <param name="n2">Segundo objeto de clase Operando</param>
        /// <returns>El resultado de la operación</returns>
        public static double operator / (Operando n1, Operando n2)
        {
            double resultado;

            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
                
        }

        /// <summary>
        /// Valida que el número ingresado por el usuario sea un número válido, sin contener letras ni símbolos
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>El resultado de la operación</returns>
        private static double ValidarOperando(string strNumero)
        {
            double numeroFinal;

            if (!double.TryParse(strNumero, out numeroFinal))
            {
                numeroFinal = 0;
            }

            /*
            Esta es la versión que utilicé yo, dado que mi VS está en inglés y reconoce el punto, pero no la coma, para números decimales
            
            if(strNumero.Contains(","))
            {
                strNumero = strNumero.Replace(",", "."); // Reemplazo la coma por un punto en caso de que el usuario se equivoque
                numeroFinal = double.Parse(strNumero);
            }
            */

            // Versión para VS en español
            if (strNumero.Contains("."))
            {
                strNumero = strNumero.Replace(".", ",");
                numeroFinal = double.Parse(strNumero);
            }
            

            return numeroFinal;
        }

        /// <summary>
        /// Valida si un número es binario, o sea que contiene únicamente 1 y 0
        /// </summary>
        /// <param name="binario">Cadena de caracteres a validar</param>
        /// <returns>Un booleano de acuerdo si la validación fue verdadera o falsa</returns>
        private static bool EsBinario(string binario)
        {
            bool esBin = true;

            foreach (char numero in binario)
            {
                if(numero != '0' && numero != '1')
                {
                    esBin = false;
                    break;
                }
            }

            return esBin;
        }

        /// <summary>
        /// Convierte un número decimal a binario siempre y cuando sea posible
        /// </summary>
        /// <param name="numero">Número a convertir</param>
        /// <returns>Una cadena con el número decimal convertido a binario, o un error en caso de no haber podido convertirlo</returns>
        public static string DecimalBinario(double numero)
        {
            string binarioReves = "";
            string binario = "";
            double numeroCasteado = Math.Abs(numero);
            int numeroInt = (int)numeroCasteado;

            while (numeroInt != 0)
            {
                double resto = numeroInt % 2;
                binarioReves += resto;
                numeroInt /= 2;
            }

            if(numero == 0)
            {
                binario = "0000";
            }

            for (int i = binarioReves.Length - 1; i >= 0; i--)
            {
                binario += binarioReves[i];
            }

            if (!Operando.EsBinario(binario))
            {
                binario = "Valor inválido";
            }

            return binario;
        }

        /// <summary>
        /// Convierte un número decimal a binario siempre y cuando sea posible
        /// </summary>
        /// <param name="numero">Cadena a convertir</param>
        /// <returns>Una cadena con el número decimal convertido a binario, o un error en caso de no haber podido convertirlo</returns>
        public static string DecimalBinario(string numero)
        {
            double numeroDouble;
            string binario = "Valor inválido";

            if(double.TryParse(numero, out numeroDouble))
            {
                binario = Operando.DecimalBinario(numeroDouble);
            }

            return binario;
        }

        /// <summary>
        /// Convierte un número binario a decimal siempre y cuando sea posible
        /// </summary>
        /// <param name="binario">Cadena del número binario a convertir</param>
        /// <returns>Una cadena con el número decimal o un error en caso de no haber podido convertirlo</returns>
        public static string BinarioDecimal(string binario)
        {
            double numDecimal = 0;
            double potencia = binario.Length - 1;
            string numDecimalStr = "";

            if (Operando.EsBinario(binario))
            {
                foreach (char uno in binario)
                {
                    if (uno == '1')
                    {
                        numDecimal += Math.Pow(2, potencia);
                    }

                    potencia--;
                }

                numDecimalStr += numDecimal;
            }
            else
            {
                numDecimalStr = "Valor inválido";
            }

            return numDecimalStr;
        }
    }
}
