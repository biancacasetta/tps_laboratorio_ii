using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstudianteYaExistenteException : Exception
    {
        /// <summary>
        /// Lanza una excepción cuando se intenta dar de alta a un estudiante que ya está ingresado al sistema (ya se registró el mismo DNI previamente)
        /// </summary>
        /// <param name="message">El mensaje a mostrar si se lanza la excepción</param>
        public EstudianteYaExistenteException(string message) : base(message)
        {
        }
    }
}
