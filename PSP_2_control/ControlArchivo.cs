using PSP_2_modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_2_control
{
    public static class ControlArchivo
    {
        /// <summary>
        /// Metodo: punto de entrada al procesamiento de archivos
        /// </summary>
        /// <param name="RutaDirectorio">Ruta del directorio donde se encuentran los archivos a procesar</param>
        public static void LeerDirectorio(string RutaDirectorio)
        {
            try
            {
                if(!Directory.Exists(RutaDirectorio))
                    throw new Exception("Directorio [" + RutaDirectorio + "] no existe");

                DirectoryInfo Directorio = new DirectoryInfo(RutaDirectorio);

                foreach (FileInfo Archivo in Directorio.GetFiles("*.txt"))
                {
                    Aplicacion.getInstancia().Lista = new Lista();
                    ProcesarArchivo(Archivo);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR: [" + e.Message + "]");
            }
        }

        /// <summary>
        /// Esta funcion recibe un archivo, lee su estructura y lo carga en la lista 
        /// </summary>
        /// <param name="Archivo">Archivo a procesar</param>
        private static void ProcesarArchivo(FileInfo Archivo)
        {
            if (!File.Exists(Archivo.FullName))
                throw new Exception("Archivo no existe");

            StreamReader ArchivoTexto = new StreamReader(Archivo.FullName);
            string Linea;
            String[] Arreglo;
            Double x, y;
            int ContadorLinea = 0;

            while ((Linea = ArchivoTexto.ReadLine()) != null)
            {
                if (Linea.Trim().Length > 0)
                {
                    Arreglo = Linea.Split(';');
                    ContadorLinea++;

                    if (Arreglo.Length != 2)
                        throw new Exception("La estructura del archivo no es correcta");

                    try
                    {
                        x = Convert.ToDouble(Arreglo[0]);
                    }
                    catch
                    {
                        throw new Exception("Archivo [" + Archivo.Name + "] Linea [" + ContadorLinea + "] En valor de X no es numerico");
                    }

                    try
                    {
                        y = Convert.ToDouble(Arreglo[1]);
                    }
                    catch
                    {
                        throw new Exception("Archivo [" + Archivo.Name + "] Linea [" + ContadorLinea + "] En valor de Y no es numerico");
                    }

                    Aplicacion.getInstancia().Lista.Agregar(x, y);
                }
            }

            ArchivoTexto.Close();
            ControlCalculo.Regresion(Archivo);
        }
    }
}
