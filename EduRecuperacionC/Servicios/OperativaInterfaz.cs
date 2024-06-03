using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones que se realicen en la aplicacion
    /// irodhan -> 28/05/2024
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que crea un usuario y lo guarda en la lista de alumnos
        /// irodhan -> 28/05/2024
        /// </summary>
        public void darAltaAlumno();
        /// <summary>
        /// Metodo que borra un usuario dentro de la lista de alumnos
        /// irodhan -> 29/05/2024
        /// </summary>
        public void borrarAlumnos();
        /// <summary>
        /// Metodo que muestra el contenido de la lista de los alumnos
        /// irodhan -> 29/05/2024
        /// </summary>
        public void mostrarLista();

        /// <summary>
        /// Metodo que modifica la informacion del alumno elegido
        /// irodhan -> 03/06/2024
        /// </summary>
        public void modificarAlumno();
    }
}
