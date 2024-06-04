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
            int opcion = 0;
            try
            {
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("|          Menu         |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("| 0. Cerrar aplicacion  |");
                Console.WriteLine("| 1. Dar alta alumnos   |");
                Console.WriteLine("| 2. Borrar alumnos     |");
                Console.WriteLine("| 3. Mostrar lista      |");
                Console.WriteLine("| 4. Guardar en fichero |");
                Console.WriteLine("| 5. Modificar datos    |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("Indique que opcion desea utilizar: ");
                opcion = Console.ReadKey(true).KeyChar - ('0');
                return opcion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int mostrarSubmenuYSeleccion()
        {
            int opcion = 0;
            try
            {
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("|  Menu modificaciones  |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("| 0. Volver             |");
                Console.WriteLine("| 1. Nombre             |");
                Console.WriteLine("| 2. Primer apellido    |");
                Console.WriteLine("| 3. Segundo apellido   |");
                Console.WriteLine("| 4. Direccion          |");
                Console.WriteLine("| 5. Telefono           |");
                Console.WriteLine("| 6. Email              |");
                Console.WriteLine("| 7. Fecha nacimiento   |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("Indique que opcion desea utilizar: ");
                opcion = Console.ReadKey(true).KeyChar - ('0');
                return opcion;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
