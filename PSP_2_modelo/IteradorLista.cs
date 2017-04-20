using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_2_modelo
{
    public class IteradorLista : Iterador
    {
        /// <summary>
        /// Primer nodo de la lista
        /// </summary>
        private Nodo Primero;

        /// <summary>
        /// Referencia al nodo que se esta apuntando actualmente
        /// </summary>
        private Nodo Actual;

        /// <summary>
        /// Metodo: constructor de la clase
        /// </summary>
        /// <param name="Primero">Recibe una referencia al primer elemento de la lista</param>
        public IteradorLista(Nodo Primero)
        {
            this.Primero = Primero;

            Actual = Primero;
        }

        /// <summary>
        /// Itera al siguiente nodo de la lista
        /// </summary>
        /// <returns></returns>
        public Nodo Siguiente()
        {
            Nodo MiNodo = null;

            if (Actual != null)
            {
                MiNodo = Actual;
                Actual = Actual.Siguiente;
            }

            return MiNodo;
        }

        /// <summary>
        /// Informa si existen mas alementos en la lista
        /// </summary>
        /// <returns>True: la lista tiene mas elementos. False: no existen mas elementos</returns>
        public bool tieneSiguiente()
        {
            if (Actual == null)
                return false;

            return true;
        }
    }
}