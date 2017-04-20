using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_2_modelo
{
    public interface Iterador
    {
        /// <summary>
        /// Metodo: encargado de pasar al siguiente en la lista
        /// </summary>
        /// <returns>Nodo de la lista</returns>
        Nodo Siguiente();

        /// <summary>
        /// Metodo: nos dice si existen mas elementos en la lista
        /// </summary>
        /// <returns>True: Exiten mas elementos en la lista. False: No hay mas elementos</returns>
        Boolean tieneSiguiente();
    }
}