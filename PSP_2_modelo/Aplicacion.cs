using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_2_modelo
{
    public class Aplicacion
    {
        /// <summary>
        /// Metodo: Constructor de la clase
        /// Crea la instancia del atributo lista
        /// </summary>
        public Aplicacion()
        {
            this.Lista = new Lista();
        }

        /// <summary>
        /// Metodo: Destructor de la clase
        /// Elimina la referencia a la lista
        /// Invoca explicitamente el recolector de basura
        /// </summary>
        ~Aplicacion()
        {
            this.Lista = null;

            GC.Collect();
        }

        /// <summary>
        /// Metodo: Propiedad Lista
        /// </summary>
        public Lista Lista { get; set; }

        /// <summary>
        /// Atributo al que deseamos garantizar su unicidad
        /// </summary>
        private static Aplicacion Instancia = null;

        /// <summary>
        /// Metodo: singleton que nos retorna la unica instancia de esta clase
        /// </summary>
        /// <returns></returns>
        public static Aplicacion getInstancia()
        {
            if (Instancia == null)
                Instancia = new Aplicacion();

            return Instancia;
        }
    }
}