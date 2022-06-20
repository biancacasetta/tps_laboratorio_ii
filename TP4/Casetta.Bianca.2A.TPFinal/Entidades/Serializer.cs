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
        private static string pathXml = "listadoEstudiantes.xml";
        private static string pathTxt = "bibliografia.txt";

        /// <summary>
        /// Serializa un tipo de referencia a un archivo de extension .xml
        /// </summary>
        /// <param name="elemento">El tipo de referencia a serializar en .xml</param>
        public static void SerializarXml(T elemento)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(pathXml))
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
                if (File.Exists(pathXml))
                {
                    using (StreamReader streamReader = new StreamReader(pathXml))
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
        /// Lee el archivo predeterminado bibiliografia.txt
        /// </summary>
        /// <returns>Tipo de referencia genérico a retornar luego de leer el archivo</returns>
        public static T LeerTxt()
        {
            T contenido;

            using (StreamReader sr = new StreamReader(pathTxt))
            {
                contenido = sr.ReadToEnd() as T;
            }

            return contenido;
        }



    }
}
