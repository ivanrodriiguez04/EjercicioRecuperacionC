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
            do { 
            AlumnoDto alumno = crearAlumno();
            Controladores.Program.listaAlumnos.Add(alumno);
            } while (Controladores.Program.listaAlumnos.Count < 3);
        }

        /// <summary>
        /// Metodo que se utiliza para pedir la informacion del nuevo usuario
        /// irodhan -> 28/05/2024
        /// </summary>
        /// <returns></returns>
        private AlumnoDto crearAlumno() 
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
                Console.WriteLine("Introduzca su fecha de nacimiento (dd/MM/yyyy): ");
                alumno.FchNacimientoAlumno = Convert.ToDateTime(Console.ReadLine());
                return alumno;
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
            MenuInterfaz mI = new MenuImplementacion();
            FicheroInterfaz fI=new FicheroImplementacion();
            int opcion = 0;
            bool cerrarMenu2=false;
            Console.WriteLine("Indique el dni del alumno a modificar:");
            string dniModificar=Console.ReadLine();

            foreach (AlumnoDto alumno in Controladores.Program.listaAlumnos) 
            {
                if (alumno.DniAlumno.Equals(dniModificar))
                {
                    while (!cerrarMenu2) 
                    {
                        opcion = mI.mostrarSubmenuYSeleccion();
                        switch (opcion)
                        {
                            case 0:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 0");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 0 (Volver al menu principal)");
                                cerrarMenu2 = true;
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 1");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 1 (Modificar nombre)");
                                Console.WriteLine("Indique el nuevo nombre: ");
                                alumno.NombreAlumno = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 2");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 2 (Modificar el 1º apellido)");
                                Console.WriteLine("Indique el primer apellido: ");
                                alumno.Apellido1Alumno = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 2");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 2 (Modificar el 2º apellido)");
                                Console.WriteLine("Indique el segundo apellido: ");
                                alumno.Apellido2Alumno = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 3");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 3 (Modificar la direccion)");
                                Console.WriteLine("Indique la nueva direccion: ");
                                alumno.DireccionAlumno = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 4");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 4 (Modificar el numero de telefono)");
                                Console.WriteLine("Indique el nuevo telefono: ");
                                alumno.TelefonoAlumno=Convert.ToInt32(Console.ReadLine());  
                                break;
                            case 6:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 5");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 4 (Modificar el email)");
                                Console.WriteLine("Indique el nuevo email: ");
                                alumno.EmailAlumno = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("[INFO] - Ha selecciona la opcion 5");
                                fI.escribirFicheroLog("Ha seleccionado la opcion 4 (Modificar la fecha de nacimiento)");
                                Console.WriteLine("Indique la nueva fecha de nacimiento (dd/MM/yyyy): ");
                                alumno.FchNacimientoAlumno = Convert.ToDateTime(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion indicada por el usuario no coincide con ninguna opcion mostrada anteriormente");
                                fI.escribirFicheroLog("Ha seleccionado una opcion que no coincide con ninguna opcion mostrada anteriormente");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El dni indicado no coincide con ningun alumno");
                }
            }
            
        }
    }
}
