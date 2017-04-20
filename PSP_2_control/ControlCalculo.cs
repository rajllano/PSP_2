using PSP_2_modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_2_control
{
    public static class ControlCalculo
    {
        /// <summary>
        /// Calculos de regresion
        /// </summary>
        /// <param name="Archivo">Recibe el archivo para mostrarlo en la consolo con sus resultados</param>
        public static void Regresion(FileInfo Archivo)
        {
            Iterador i = Aplicacion.getInstancia().Lista.Iterador();
            Nodo NodoActual;

            Double SumaXCuadrado = 0;
            Double SumaXporY = 0;
            Double SumaYCuadrado = 0;
            Double SumaX = 0;
            Double SumaY = 0;
            Double Contador = 0;

            while(i.tieneSiguiente())
            {
                NodoActual = i.Siguiente();

                SumaX += NodoActual.x;
                SumaY += NodoActual.y;
                SumaXCuadrado += Math.Pow(NodoActual.x,2);
                SumaYCuadrado += Math.Pow(NodoActual.y, 2);
                SumaXporY += (NodoActual.x * NodoActual.y);
                Contador++;
            }

            Double B1 = (SumaXporY - (Contador * (SumaX / Contador) * (SumaY / Contador))) / (SumaXCuadrado - (Contador * Math.Pow((SumaX / Contador), 2)));

            Double rxy = ((Contador * SumaXporY) - (SumaX * SumaY)) / (Math.Sqrt(((Contador * SumaXCuadrado) - Math.Pow(SumaX, 2)) * ((Contador * SumaYCuadrado) - Math.Pow(SumaY, 2))));

            Double r2 = Math.Pow(rxy, 2);

            Double B0 = (SumaY / Contador) - B1 * (SumaX / Contador);

            Double yk = B0 + B1 * 386;

            String Respuesta = String.Empty;

            Respuesta = String.Format("{0} *** B0 = {1} *** B1 = {2} *** rxy = {3} *** r2 = {4} *** yk = {5}",Archivo.Name, Math.Round(B0,4), Math.Round(B1,4), Math.Round(rxy,4), Math.Round(r2,4), Math.Round(yk,4));

            Console.WriteLine(Respuesta);
        }
    }
}
