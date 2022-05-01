﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo
        { 
            CuatroPuertas,
            CincoPuertas
        }

        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
        }
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra los datos de una Sedan en formato string
        /// </summary>
        /// <returns>Una string con los datos de la Sedan</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{(string)this}");
            sb.AppendLine($"TIPO: {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
