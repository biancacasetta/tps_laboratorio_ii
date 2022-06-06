using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instituto
    {
        private List<Estudiante> estudiantes;

        public Instituto()
        {
            estudiantes = new List<Estudiante>();
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de estudiantes
        /// </summary>
        public List<Estudiante> Estudiantes
        {
            get
            {
                return this.estudiantes;
            }
            set
            {
                this.estudiantes = value;
            }
        }

        /// <summary>
        /// Se recorre el atributo de la lista de estudiantes y se busca si un DNI especifico ya se encuentra en la lista.
        /// </summary>
        /// <param name="dni">El DNI a buscar</param>
        /// <returns>El estudiante que coincidio con el DNI. Si no se encuentra, retorna null</returns>
        public Estudiante BuscarEstudiantePorDni(int dni)
        {
            Estudiante aux = null;

            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Dni == dni)
                {
                    aux = estudiante;
                    break;
                }
            }

            return aux;
        }

        /// <summary>
        /// Se verifica si un Estudiante se encuentra en la lista del Instituto.
        /// </summary>
        /// <param name="i">Instituto con la lista de Estudiante</param>
        /// <param name="e">Estudiante a buscar en el Instituto</param>
        /// <returns>Un booleano correspondiente a si se encontro o no el Estudiante</returns>
        public static bool operator == (Instituto i, Estudiante e)
        {
            bool esta = false;

            if (i.estudiantes is not null)
            {
                foreach (Estudiante estudiante in i.estudiantes)
                {
                    if (estudiante == e)
                    {
                        esta = true;
                        break;
                    }
                }
            }

            return esta;
        }
        public static bool operator != (Instituto i, Estudiante e)
        {
            return !(i == e);
        }

        /// <summary>
        /// Muestra la información de un Instituto según el formato asignado.
        /// </summary>
        /// <returns>Una string con los datos del Instituto</returns>
        public override string ToString()
        {
            StringBuilder datosInstituto = new StringBuilder();

            if (estudiantes is not null)
            {
                foreach (Estudiante e in estudiantes)
                {
                    datosInstituto.AppendLine(e.ToString());
                }
            }

            return datosInstituto.ToString();
        }
    }
}
