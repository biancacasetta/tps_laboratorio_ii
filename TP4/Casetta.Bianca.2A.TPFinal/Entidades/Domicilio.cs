using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Domicilio
    {
        private string calle;
        private int altura;
        private string ciudad;
        private string provincia;
        private int codigoPostal;

        public Domicilio()
        {

        }
        public Domicilio(string calle, int altura, string ciudad, string provincia, int codigoPostal)
        {
            this.calle = calle;
            this.altura = altura;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.codigoPostal = codigoPostal;
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de calle
        /// </summary>
        public string Calle
        {
            get
            {
                return this.calle;
            }
            set
            {
                this.calle = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de altura
        /// </summary>
        public int Altura
        {
            get
            {
                return this.altura;
            }
            set
            {
                this.altura = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de ciudad
        /// </summary>
        public string Ciudad
        {
            get
            {
                return this.ciudad;
            }
            set
            {
                this.ciudad = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de provincia
        /// </summary>
        public string Provincia
        {
            get
            {
                return this.provincia;
            }
            set
            {
                this.provincia = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura-escritura para el atributo de codigoPostal
        /// </summary>
        public int CodigoPostal
        {
            get
            {
                return this.codigoPostal;
            }
            set
            {
                this.codigoPostal = value;
            }
        }

        /// <summary>
        /// Muestra la información de un Domicilio según el formato asignado
        /// </summary>
        /// <returns>Una string con los datos del Domicilio</returns>
        public override string ToString()
        {
            StringBuilder datosDomicilio = new StringBuilder();
            datosDomicilio.AppendLine($"{this.Calle} {this.Altura}");
            datosDomicilio.AppendLine($"CP: {this.CodigoPostal} - {this.Ciudad}, {this.Provincia}");

            return datosDomicilio.ToString();
        }
    }
}
