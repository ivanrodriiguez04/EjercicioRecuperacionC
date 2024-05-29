using EduRecuperacionC.Dtos;
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
            string nombreFichero="9";
            try
            {
                //Guardamos la fecha actual
                DateTime fecha = DateTime.Now;
                //Guardamos la fecha con un formato fijo en un string
                string fechaActual = fecha.ToString("ddMMyyyy");
                //Guardamos la concatenacion de los parametros en un string
                nombreFichero = string.Concat("log-", fechaActual, ".txt");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("[INFO] - Ha ocurrido un error a la hora de la creacion del nombre del fichero");
            }
            //Devolvemos el nombre del fichero
            return nombreFichero;


        }
        /// <summary>
        /// Metodo que calcula el id de los alumnos
        /// irodhan -> 28/05/2024
        /// </summary>
        /// <param name="listaAlumnos"></param>
        /// <returns>Devuvlve el id asignado al nuevo alumnoa</returns>
        public static long asignarId() 
        {
            List<AlumnoDto> nuevaListaAlumnos = Controladores.Program.listaAlumnos;
            long id;
            int tamanyoLista= nuevaListaAlumnos.Count;
            
            if (tamanyoLista>0)
            {
                    id = nuevaListaAlumnos[tamanyoLista - 1].IdAlumno + 1;
            }
            else 
            {
                id = 1;
            }

            return id;
        }
    }
}
