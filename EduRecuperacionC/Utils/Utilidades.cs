using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Utils
{
    /// <summary>
    /// Clase de las utilidades de la aplicacion
    /// irodhan -> 27/05/2024
    /// </summary>
    internal static class Utilidades
    {
        /// <summary>
        /// Metodo para la creacion del nombre del fichero log
        /// irodhan -> 27/05/2024
        /// </summary>
        /// <returns>Devuelve el nombre del fichero log</returns>
        public static string crearNombreLog() 
        {
            //Guardamos la fecha actual
            DateTime fecha = DateTime.Now;
            //Guardamos la fecha con un formato fijo en un string
            string fechaActual=fecha.ToString("ddMMyyyy");
            //Guardamos la concatenacion de los parametros en un string
            string nombreFichero = string.Concat("log-", fechaActual, ".txt");
            //Devolvemos el nombre del fichero
            return nombreFichero;
            
        }
    }
}
