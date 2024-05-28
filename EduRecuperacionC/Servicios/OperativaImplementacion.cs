using EduRecuperacionC.Dtos;
using EduRecuperacionC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la aplicacion
    /// irodhan -> 28/05/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaAlumno(List<AlumnoDto> listaAlumnos)
        {
            AlumnoDto alumno = crearAlumno();
            listaAlumnos.Add(alumno);
        }
        private AlumnoDto crearAlumno() 
        {
            FicheroImplementacion fI = new FicheroImplementacion();
            try 
            {
                AlumnoDto alumno = new AlumnoDto();
                alumno.IdAlumno = Utilidades.asignarId();
                Console.WriteLine("Introduzca el nombre del alumno: ");
                alumno.NombreAlumno = Console.ReadLine();
                Console.WriteLine("Introduzca el primer apellido del alumno: ");
                alumno.Apellido1Alumno = Console.ReadLine();
                Console.WriteLine("Introduzca el segundo apellido del alumno: ");
                alumno.Apellido2Alumno = Console.ReadLine();
                Console.WriteLine("Introduzca el dni del alumno: ");
                alumno.DniAlumno = Console.ReadLine();
                Console.WriteLine("Introduzca la direccion del alumno: ");
                alumno.DireccionAlumno = Console.ReadLine();
                Console.WriteLine("Introduzca el telefono del alumno: ");
                alumno.TelefonoAlumno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el email del alumno: ");
                alumno.NombreAlumno = Console.ReadLine();
                return alumno;
            }
            catch(Exception ex) 
            {
                fI.escribirFicheroLog(ex.Message);
                throw;
            }
        }
    }
}
