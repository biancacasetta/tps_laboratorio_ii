﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(Vehiculo.EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Muestra los datos de una SUV en formato string
        /// </summary>
        /// <returns>Una string con los datos de la SUV</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{(string)this}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
