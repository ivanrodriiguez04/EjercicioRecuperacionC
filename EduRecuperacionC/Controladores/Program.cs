using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Utils;

namespace EduRecuperacionC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 27/05/2024
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 27/05/2024
        /// </summary>
        /// <param name="args"></param>

        //Variables 
        static string rutaCarpetaLog = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\Recuperacion\\EduRecuperacionC\\Logs\\"; //Se termina en dos barras para que se añada dentro de la carpeta
        public static string rutaFicheroLog = string.Concat(rutaCarpetaLog, Utilidades.crearNombreLog());
        public static string rutaFichero = "C:\\Users\\csi22-irodhan\\Desktop\\Programacion\\Recuperacion\\EduRecuperacionC\\Ficheros\\FicheroLista.txt";
        public static List<AlumnoDto> listaAlumnos = new List<AlumnoDto>();

        static void Main(string[] args)
        {
            //Ordena por los dni de mayor a menor y si son igual , se ordena por orden alfabetico dentro de los ficheros
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            FicheroInterfaz fI = new FicheroImplementacion();
            OperativaInterfaz oI = new OperativaImplementacion();
            fI.cargaInicial();
            //Variables
            int opcionSeleccionada = 0;
            bool cerrarMenu = true;

            //Creamos un bucle do...while
            do
            {
                try
                {
                    //Guardamos la opcion seleccionada por el usuario
                    opcionSeleccionada = mI.mostrarMenuYSeleccion();
                    //Creamos un switch con la opcion indicada
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 0");
                            Console.WriteLine("[INFO] - La aplicacion va a cerrarse");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 0 (Cerrar aplicacion)");
                            cerrarMenu = false;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 1");
                            Console.WriteLine("[INFO] - Se va a dar el alta de alumnos");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 1 (Dar de alta a un nuevo alumno)");
                            oI.darAltaAlumno();
                            break;
                        case 2:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 2");
                            Console.WriteLine("[INFO] - Se va a borrar alumnos");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 2 (Se va a borrar a un alumno)");
                            oI.borrarAlumnos();
                            break;
                        case 3:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 3");
                            Console.WriteLine("[INFO] - Se va a mostrar la lista");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 3 (Se va mostrar la lista)");
                            oI.mostrarLista();
                            break;
                        case 4:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 4");
                            Console.WriteLine("[INFO] - Se va a guardar la informacion dentro de un fichero");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 4 (Guardar lista en fichero)");
                            fI.guardarLista();
                            break;
                        case 5:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 5");
                            Console.WriteLine("[INFO] - Se va a modificar la informacion de un alumno");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 4 (Modificar datos)");
                            oI.modificarAlumno();
                            break;
                        default:
                            Console.WriteLine("[INFO] - La opcion indicada por el usuario no coincide con ninguna opcion mostrada anteriormente");
                            fI.escribirFicheroLog("Ha seleccionado una opcion que no coincide con ninguna opcion mostrada anteriormente");
                            break;
                    }
                }
                catch (Exception e)
                {
                    try
                    {
                        fI.escribirFicheroLog(e.Message);
                    }
                    catch (Exception ex) { }
                }
            } while (cerrarMenu);
        }
    }
}
