using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(EstudianteParticular))]
    [XmlInclude(typeof(EstudianteCurso))]
    [XmlInclude(typeof(EstudianteExterno))]
    public abstract class Estudiante
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected DateTime fechaNacimiento;
        protected string genero;
        protected double telefono;
        protected Domicilio domicilio;
        protected ETipoEstudiante tipo;
        protected string eMail;

        public Estudiante()
        {

        }
        protected Estudiante(string nombre, string apellido, int dni, DateTime fechaNacimiento, string genero, double telefono, Domicilio domicilio, ETipoEstudiante tipo, string eMail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.tipo = tipo;
            this.eMail = eMail;
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de fechaNacimiento
        /// </summary>
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de genero
        /// </summary>
        public string Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de telefono
        /// </summary>
        public double Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de domicilio
        /// </summary>
        public Domicilio Domicilio
        {
            get
            {
                return this.domicilio;
            }
            set
            {
                this.domicilio = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de tipo
        /// </summary>
        public ETipoEstudiante TipoEstudiante
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de eMail
        /// </summary>
        public string EMail
        {
            get
            {
                return this.eMail;
            }
            set
            {
                this.eMail = value;
            }
        }

        /// <summary>
        /// Compara dos estudiantes. Son iguales si tienen el mismo DNI.
        /// </summary>
        /// <param name="e1">Primer estudiante a comparar</param>
        /// <param name="e2">Segundo estudiante a comparar</param>
        /// <returns></returns>
        public static bool operator == (Estudiante e1, Estudiante e2)
        {
            return e1.Dni == e2.Dni;
        }
        public static bool operator != (Estudiante e1, Estudiante e2)
        {
            return !(e1 == e2);
        }

        /// <summary>
        /// Muestra la información de un Estudiante según el formato asignado
        /// </summary>
        /// <returns>Una string con los datos del Estudiante</returns>
        public override string ToString()
        {
            StringBuilder datosEstudiante = new StringBuilder();
            datosEstudiante.AppendLine($"NOMBRE: {this.Nombre}");
            datosEstudiante.AppendLine($"APELLIDO: {this.Apellido}");
            datosEstudiante.AppendLine($"DNI: {this.Dni}");
            datosEstudiante.AppendLine($"FECHA DE NACIMIENTO: {String.Format($"{this.FechaDeNacimiento.ToShortDateString():ddMMyyyy}")}");
            datosEstudiante.AppendLine($"GENERO: {this.Genero}");
            datosEstudiante.AppendLine($"TELEFONO: {this.Telefono}");
            datosEstudiante.AppendLine($"E-MAIL: {this.EMail}");
            datosEstudiante.Append($"DOMICILIO: \n{this.Domicilio}");
            datosEstudiante.AppendLine($"TIPO DE ESTUDIANTE: {this.TipoEstudiante}");

            return datosEstudiante.ToString();
        }
    }
}
