using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y obtiene la opcion indicada por el usuario
        /// irodhan -> 27/05/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo que muestra y obtiene la opcion que desea modificar el usuario
        /// irodhan -> 03/06/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarSubmenuYSeleccion();
    }
}
