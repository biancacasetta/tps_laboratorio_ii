using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class BaseDeDatos
    {
        private static string cadenaConexion;

        static BaseDeDatos()
        {
            BaseDeDatos.cadenaConexion = "Server=.;Database=Instituto;Trusted_Connection=True";
        }

        /// <summary>
        /// Obtiene la información de la base de datos filtrando la tabla de elementos por Nivel
        /// Como la tabla principal es la de Cursos, se muestra toda la informacion de esa tabla y se une con EstudiantesCurso
        /// para mostrar tambien los datos basicos de los estudiantes que conforman el curso (Nombre, Apellido, DNI)
        /// </summary>
        /// <param name="nivel">El nivel a filtrar</param>
        /// <returns>Una lista de EstudianteCurso que pertenecen al nivel indicado por parámetro</returns>
        public static List<EstudianteCurso> LeerPorNivel(this string nivel)
        {
            List<EstudianteCurso> listaEstudiantesCurso = new List<EstudianteCurso>();
            string query = "select Nivel, DNI, Nombre, Apellido, Cuota, Horarios, Docente from EstudiantesCurso\n" +
                "join Cursos on EstudiantesCurso.Nivel_Curso = Cursos.Nivel where Nivel = @nivel";

            using (SqlConnection conexion = new SqlConnection(BaseDeDatos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("nivel", nivel);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int dni = reader.GetInt32(1);
                    string nombre = reader.GetString(2);
                    string apellido = reader.GetString(3);
                    int cuota = reader.GetInt32(4);
                    string horarios = reader.GetString(5);
                    string docente = reader.GetString(6);

                    EstudianteCurso estudiante =
                        new EstudianteCurso(dni, nombre, apellido, new Curso(Enum.Parse<ENivel>(nivel), cuota, horarios, docente));
                    listaEstudiantesCurso.Add(estudiante);
                }
            }
            return listaEstudiantesCurso;
        }

        /// <summary>
        /// Se inserta un nuevo elemento a la tabla de EstudiantesCurso (solo determinados datos, los datos completos se ven en el .xml)
        /// </summary>
        /// <param name="estudiante">El EstudianteCurso a insertar</param>
        public static void Alta(EstudianteCurso estudiante)
        {
            string query = "INSERT INTO EstudiantesCurso (Nombre, Apellido, DNI, Nivel_Curso) values (@Nombre, @Apellido, @Dni, @Nivel)";
            using (SqlConnection conexion = new SqlConnection(BaseDeDatos.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Nombre", estudiante.Nombre);
                cmd.Parameters.AddWithValue("Apellido", estudiante.Apellido);
                cmd.Parameters.AddWithValue("Dni", estudiante.Dni);
                cmd.Parameters.AddWithValue("Nivel", estudiante.Curso.Nivel.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Se elimina un elemento de la tabla filtrando por DNI
        /// </summary>
        /// <param name="dni">El DNI del elemento a eliminar</param>
        public static void Baja(this int dni)
        {

            string query = "DELETE FROM EstudiantesCurso WHERE DNI = @Dni";
            using (SqlConnection conexion = new SqlConnection(BaseDeDatos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Dni", dni);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Se actualizan los datos de un elemento de la tabla filtrando por DNI
        /// </summary>
        /// <param name="estudiante">El EstudianteCurso a actualizar</param>
        /// <param name="dni">El DNI del elemento a actualizar</param>
        public static void Actualizar(this EstudianteCurso estudiante, int dni)
        {

            string query = "UPDATE EstudiantesCurso SET Nombre = @Nombre, Apellido = @Apellido, Nivel_Curso = @Nivel WHERE DNI = @Dni";
            using (SqlConnection conexion = new SqlConnection(BaseDeDatos.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Dni", dni);
                cmd.Parameters.AddWithValue("Nombre", estudiante.Nombre);
                cmd.Parameters.AddWithValue("Apellido", estudiante.Apellido);
                cmd.Parameters.AddWithValue("Nivel", estudiante.Curso.Nivel.ToString());
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
