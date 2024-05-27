using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicacion
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|----------------------|");
            Console.WriteLine("|         Menu         |");
            Console.WriteLine("|----------------------|");
            Console.WriteLine("| 0. Cerrar aplicacion |");
            Console.WriteLine("| 1. Dar alta alumnos  |");
            Console.WriteLine("|----------------------|");
            Console.WriteLine("Indique que opcion desea utilizar: ");
            int opcion= Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
