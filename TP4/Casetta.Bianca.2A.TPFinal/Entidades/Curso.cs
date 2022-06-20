using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private ENivel nivel;
        private int cuotaMensual;
        private string horarios;
        private string docente;

        public Curso()
        {
            
        }
        public Curso(ENivel nivel)
        {
            this.nivel = nivel;
            ObtenerCurso(this.nivel);
        }

        public Curso(ENivel nivel, int cuotaMensual, string horarios, string docente)
        {
            this.nivel = nivel;
            this.cuotaMensual = cuotaMensual;
            this.horarios = horarios;
            this.docente = docente;
        }

        /// <summary>
        /// Se completa la instancia de un Curso a través del Nivel que se obtiene desde el Form de Alta o Modificación.
        /// Los cursos no son modificables en el sistema y con saber el Nivel se asignan los otros atributos de forma predeterminada.
        /// </summary>
        /// <param name="nivel">El nivel del curso</param>
        public void ObtenerCurso(ENivel nivel)
        {
            this.nivel = nivel;
            switch(nivel)
            {
                case ENivel.Primer_Año:
                    this.cuotaMensual = 3000;
                    this.horarios = "Martes y Jueves 18hs";
                    this.docente = "Esteban Laporte";
                    break;
                case ENivel.Segundo_Año:
                    this.cuotaMensual = 3500;
                    this.horarios = "Lunes y Jueves 16hs";
                    this.docente = "Laura Perez";
                    break;
                case ENivel.Tercer_Año:
                    this.cuotaMensual = 4000;
                    this.horarios = "Miercoles y Viernes 16hs";
                    this.docente = "Silvia Canelo";
                    break;
                case ENivel.Cuarto_Año:
                    this.cuotaMensual = 4500;
                    this.horarios = "Viernes 15hs";
                    this.docente = "Mariano Torres";
                    break;
                case ENivel.Quinto_Año:
                    this.cuotaMensual = 5000;
                    this.horarios = "Martes y Miercoles 17hs";
                    this.docente = "Osvaldo Alegre";
                    break;
                case ENivel.Sexto_Año:
                    this.cuotaMensual = 5500;
                    this.horarios = "Jueves y Viernes 17hs";
                    this.docente = "Alejandro Castiglione";
                    break;
            }

        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de nivel
        /// </summary>
        public ENivel Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de cuotaMensual
        /// </summary>
        public int CuotaMensual
        {
            get
            {
                return this.cuotaMensual;
            }
            set
            {
                this.cuotaMensual = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de horarios
        /// </summary>
        public string Horarios
        {
            get
            {
                return this.horarios;
            }
            set
            {
                this.horarios = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de docente
        /// </summary>
        public string Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

        /// <summary>
        /// Muestra la información de un Curso, incluyendo los estudiantes que lo componen
        /// </summary>
        /// <returns>Una string con los datos del Curso</returns>
        /*public override string ToString()
        {
            StringBuilder datosCurso = new StringBuilder();
            datosCurso.AppendLine($"INFORMACION DE {this.Nivel}\n");
            datosCurso.AppendLine($"CUOTA MENSUAL: ${this.CuotaMensual}");
            datosCurso.AppendLine($"HORARIOS: {this.Horarios}");
            datosCurso.AppendLine($"DOCENTE: {this.Docente}");
            datosCurso.AppendLine($"LISTA DE ESTUDIANTES:");
            foreach (Estudiante ec in instituto.Estudiantes)
            {
                if (ec is EstudianteCurso && ((EstudianteCurso)ec).Curso.Nivel == nivel)
                {
                    datosCurso.AppendLine($"{ec.Nombre} {ec.Apellido}");
                }
            }

            return datosCurso.ToString();
        }*/

    }
}
