using EduRecuperacionC.Dtos;
using EduRecuperacionC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la aplicacion
    /// irodhan -> 28/05/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void borrarAlumnos()
        {
            FicheroImplementacion fI = new FicheroImplementacion();
            AlumnoDto aux = new AlumnoDto();

            Console.WriteLine("Introduzca el dni del alumno a borrar: ");
            string dniBorrar=Console.ReadLine();

            foreach (AlumnoDto alumno in Controladores.Program.listaAlumnos) 
            { 
                if (alumno.DniAlumno.Equals(dniBorrar))
                {
                    aux = alumno;
                    break;
                }
            }
            Controladores.Program.listaAlumnos.Remove(aux);
        }

        public void darAltaAlumno()
        {
            AlumnoDto alumno = crearAlumno();
            Controladores.Program.listaAlumnos.Add(alumno);
        }

        /// <summary>
        /// Metodo que se utiliza para pedir la informacion del nuevo usuario
        /// irodhan -> 28/05/2024
        /// </summary>
        /// <returns></returns>
        private AlumnoDto crearAlumno() 
        {
            FicheroImplementacion fI = new FicheroImplementacion();
            char confirmacion = 'a';
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
                alumno.EmailAlumno = Console.ReadLine();
                return alumno;
            }
            catch(Exception ex) 
            {
                fI.escribirFicheroLog(ex.Message);
                throw;
            }
        }

         public void mostrarLista()
        {
            foreach (AlumnoDto alumno in Controladores.Program.listaAlumnos) 
            {
                Console.WriteLine(alumno.ToString());
            }
        }

        public void modificarAlumno()
        {
            AlumnoDto alumno = new AlumnoDto();
            Console.WriteLine("Indique el dni del alumno a modificar:");
            string dniModificar=Console.ReadLine();

            if (alumno.DniAlumno.Equals(dniModificar)) 
            { 
            
            }
            else 
            {
                Console.WriteLine("El dni indicado no coincide con ningun alumno");
            }
        }
    }
}
