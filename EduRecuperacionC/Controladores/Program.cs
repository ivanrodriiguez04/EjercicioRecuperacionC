using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static string rutaFicheroLog = string.Concat(rutaCarpetaLog,Utilidades.crearNombreLog());
        public static List<AlumnoDto> listaAlumnos=new List<AlumnoDto>();

        static void Main(string[] args) 
        {
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            FicheroInterfaz fI=new FicheroImplementacion();
            //Variables
            int opcionSeleccionada = 0;
            bool cerrarMenu=true;

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
                            fI.escribirFicheroLog("Ha seleccionado la opcion 0");
                            cerrarMenu = false;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] - Ha selecciona la opcion 1");
                            Console.WriteLine("[INFO] - Se va a dar el alta de alumnos");
                            fI.escribirFicheroLog("Ha seleccionado la opcion 1");
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
                    }catch (Exception ex) {}
                }
            } while (cerrarMenu);
        }
    }
}
