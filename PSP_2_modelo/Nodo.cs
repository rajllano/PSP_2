using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_2_modelo
{
    public class Nodo
    {
        /// <summary>
        /// Metodo: Valor de x
        /// </summary>
        public Double x { get; set; }

        /// <summary>
        /// Metodo: Valor de y
        /// </summary>
        public Double y { get; set; }

        /// <summary>
        /// Metodo: Siguiente nodo en la lista
        /// </summary>
        public Nodo Siguiente { get; set; }
    }
}