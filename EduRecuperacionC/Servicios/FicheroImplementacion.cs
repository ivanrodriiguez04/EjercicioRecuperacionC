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
    /// Clase que implementa a la interfaz de los ficheros
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void cargaInicial()
        {
            try 
            {
                string[] lineas = File.ReadAllLines(Controladores.Program.rutaFichero);
                foreach (string linea in lineas)
                {
                    AlumnoDto alumno = new AlumnoDto();
                    string[] campos = linea.Split(";");
                    long i = Convert.ToInt64(campos[0]);
                    alumno.IdAlumno = i;
                    alumno.NombreAlumno = campos[1];
                    alumno.Apellido1Alumno = campos[2];
                    alumno.Apellido2Alumno = campos[3];
                    alumno.DniAlumno = campos[4];
                    alumno.DireccionAlumno = campos[5];
                    int tel = Convert.ToInt32(campos[6]);
                    alumno.TelefonoAlumno = tel;
                    alumno.EmailAlumno = campos[7];
                    DateTime fch = Convert.ToDateTime(campos[8]);
                    alumno.FchNacimientoAlumno = fch;
                    Controladores.Program.listaAlumnos.Add(alumno);
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        public void escribirFicheroLog(string mensaje)
        {
            StreamWriter sw=null;

            try
            {
                using (sw = new StreamWriter(Controladores.Program.rutaFicheroLog, true)) 
                {
                    sw.WriteLine(mensaje);
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void guardarLista()
        {
            StreamWriter sw = null;
            try
            {
                using (sw = new StreamWriter(Controladores.Program.rutaFichero)) 
                {
                    foreach (AlumnoDto alumno in Controladores.Program.listaAlumnos)
                    {
                        sw.WriteLine(alumno.ToString(';'));
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            
        }
    }
}
