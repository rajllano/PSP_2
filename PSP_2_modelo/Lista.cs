using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_2_modelo
{
    public class Lista
    {
        /// <summary>
        /// Metodo: primer elemento de la lista
        /// </summary>
        public Nodo Primero { get; set; }

        /// <summary>
        /// Metodo: ultimo elemento de la lista
        /// </summary>
        public Nodo Ultimo { get; set; }

        /// <summary>
        /// Metodo: constructor encargado de inicializar los atributos de la clase
        /// </summary>
        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        /// <summary>
        /// Metodo: agrega un objeto de la coleccion
        /// </summary>
        /// <param name="x">Valor de x</param>
        /// <param name="y">Valor de y</param>
        public void Agregar(Double x, Double y)
        {
            Nodo NodoNuevo = new Nodo();

            NodoNuevo.x = x;
            NodoNuevo.y = y;

            if (this.Primero == null)
            {
                this.Primero = NodoNuevo;
                this.Primero.Siguiente = null;

                this.Ultimo = NodoNuevo;
            }
            else
            {
                this.Ultimo.Siguiente = NodoNuevo;
                NodoNuevo.Siguiente = null;

                Ultimo = NodoNuevo;
            }
        }

        /// <summary>
        /// Iterador para recorrer la lista
        /// </summary>
        /// <returns>Objeto iterador que abstrae el recorrido de la lista</returns>
        public IteradorLista Iterador()
        {
            return new IteradorLista(this.Primero);
        }
    }
}