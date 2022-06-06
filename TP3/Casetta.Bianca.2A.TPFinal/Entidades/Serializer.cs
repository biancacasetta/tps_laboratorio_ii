using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase estatica y generica para poder (de)serializar diferentes tipos de datos. Tienen que ser tipos de referencia.
    /// </summary>
    /// <typeparam name="T">El tipo de dato de referencia a (de)serializar</typeparam>
    public static class Serializer<T> where T : class
    {
        private static string path = "listadoEstudiantes.xml";

        /// <summary>
        /// Serializa un tipo de referencia a un archivo de extension .xml
        /// </summary>
        /// <param name="elemento">El tipo de referencia a serializar en .xml</param>
        public static void SerializarXml(T elemento)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(streamWriter, elemento);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deserializa un archivo (predeterminado en el atributo path) si es que existe y desde una extension .xml
        /// </summary>
        /// <returns>El tipo de referencia a retornar al deserializar</returns>
        public static T DeserializarXml()
        {
            T elemento = null;

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(T));
                        elemento = xml.Deserialize(streamReader) as T;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return elemento;
        }

        /// <summary>
        /// Serializa un tipo de referencia a un archivo de extension .json
        /// </summary>
        /// <param name="elemento">El tipo de referencia a serializar en .json</param>
        public static void SerializarJson(T elemento)
        {

            string pathJson = "InformacionCursos.json";
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(elemento, opciones);

                File.WriteAllText(pathJson, jsonString);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
