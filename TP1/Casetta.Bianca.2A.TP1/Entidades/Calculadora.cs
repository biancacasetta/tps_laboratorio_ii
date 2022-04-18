using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador elegido del ComboBox sea una de las cuatro operaciones contempladas
        /// </summary>
        /// <param name="operador">Caracter que se selecciona desde el ComboBox del form</param>
        /// <returns>Un caracter que indicará la operación a realizar (suma/resta/multiplicación/división)</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorFinal;

            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                operadorFinal = operador;
            }
            else
            {
                operadorFinal = '+';
            }

            return operadorFinal;
        }

        /// <summary>
        /// Realiza una operación (suma/resta/multiplicación/división) de dos objetos Operando según lo indicado por el usuario, con previa validación del método ValidarOperador
        /// </summary>
        /// <param name="num1">Primer objeto de clase Operando</param>
        /// <param name="num2">Segundo objeto de clase Operando</param>
        /// <param name="operador">Caracter que indica la operacióna a realizar</param>
        /// <returns>El resultado de la operación realizada</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch(Calculadora.ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
