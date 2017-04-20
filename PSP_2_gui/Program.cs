using PSP_2_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_2_gui
{
    class Program
    {
        /// <summary>
        /// Punto de entrada de la aplicación
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*** PSP2 - Regresion lineal                  ***");
            Console.WriteLine("************************************************");
            Console.WriteLine("Para procesar un conjunto de valores X y Y debe");
            Console.WriteLine("crear un archivo de texto con la extención .txt");
            Console.WriteLine(@"y guardarlos en el directorio C:\PSP2");
            Console.WriteLine(@"La estructura del archivo debe ser:");
            Console.WriteLine(@"ValorX;ValorY");
            Console.WriteLine(@"Ejemplo:");
            Console.WriteLine(@"1;5");
            Console.WriteLine(@"4;6");
            Console.WriteLine(@"6,7;7,7");
            Console.WriteLine("---Presione una tecla para iniciar el procesamiento---");
            Console.ReadKey();

            ControlArchivo.LeerDirectorio(@"C:\PSP2");
            Console.ReadKey();
        }
    }
}
