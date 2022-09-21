using System.IO;
using NLog;
namespace TPN2
{
    static class HelperDeArchivos
    {
        static int bandera = 0;
        static int contador = 1;
        static public void EscribirEnArchivo(string ruta,string archivo,string contenido)
        {  
            string rutaArchivo = ruta + archivo;             
            if(!File.Exists(rutaArchivo))
            {
                bandera = 1;
            }
            StreamWriter archivoW = File.AppendText(rutaArchivo);
            if(bandera == 1)
            {
                archivoW.WriteLine("ID;DNI;Nombre;Apellido;Curso");
            }
            
            archivoW.WriteLine(contenido);
            archivoW.Close();
        }

        static public void LimpiarArchivo(string ruta, string archivo)
        {
            if(File.Exists(ruta+archivo))
            {
                File.Delete(ruta+archivo);
                System.Console.WriteLine($"\nSe a vaciado el contenido de {archivo}\n");
            } else {
                System.Console.WriteLine($"\nNo existe el archivo {archivo}\n");
            }
        }
    } 
}
