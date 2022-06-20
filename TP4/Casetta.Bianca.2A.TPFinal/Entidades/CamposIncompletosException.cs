using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposIncompletosException : Exception
    {
        /// <summary>
        /// Lanza una excepción cuando alguno de los campos del formulario de Alta o Modificación se encuentra vacío
        /// </summary>
        /// <param name="message">El mensaje a mostrar si se lanza la excepción</param>
        public CamposIncompletosException(string message) : base(message)
        {
        }

    }
}
