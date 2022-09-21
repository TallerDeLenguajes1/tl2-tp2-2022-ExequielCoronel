using NLog;

namespace TPN2
{
    class Program
    {
        static void Main(string [] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            string rutaArchivoCSV = @"C:\Users\execo\Escritorio\Universidad\3ero\2doCuatrimestre\TallerDeLenguajesII\Practica\TPN2\tl2-tp2-2022-ExequielCoronel\Punto3\";
            string archivo;
            int confirmar;
            string Nombre, Apellido;
            Int64 DNI;
            int ID;
            Curso curso; 
            try
            {
                do
                {
                    System.Console.WriteLine("Carga de nuevo alumno: \n");
                    System.Console.WriteLine("Ingrese un numero entero identificador del alumno: ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Ingrese el Nombre: ");
                    Nombre = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el Apellido: ");
                    Apellido = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el DNI: ");
                    DNI = Convert.ToInt64(Console.ReadLine());
                    System.Console.WriteLine("A que curso asiste? 1=Atletismo, 2=Voley, 3=Futbol");
                    switch(Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            curso = Curso.Atletismo;
                            archivo = "atletismo.csv";
                            break;
                        case 2:
                            curso = Curso.Voley;
                            archivo = "voley.csv";
                            break;
                        case 3:
                            curso = Curso.Futbol;
                            archivo = "futbol.csv";
                            break;
                        default:
                            curso = Curso.Futbol;
                            archivo = "futbol.csv";
                            break;
                    }
                    Alumno alumno = new Alumno(ID,Nombre, Apellido, DNI, curso);
                    string contenido = alumno.ID1+ ";" +alumno.DNI1 + ";" + alumno.Apellido1 + ";" + alumno.Nombre1 + ";" +alumno.Curso;
                    HelperDeArchivos.EscribirEnArchivo(rutaArchivoCSV,archivo,contenido);
                    System.Console.WriteLine("Desea cargar otro alumno? 0<--No, 1<--Si");
                    confirmar = Convert.ToInt32(Console.ReadLine());
                }while(confirmar != 0);
            } catch(Exception ex) {
                var mensaje = " Error mensaje: "+ ex.Message;
                if(ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                mensaje = mensaje + " Stack trace: " + ex.StackTrace;

                logger.Error(mensaje);
            }
            
        }
    }
}