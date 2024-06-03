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
                if (File.Exists(Controladores.Program.rutaFichero))
                {
                    string[] lineas = File.ReadAllLines(Controladores.Program.rutaFichero);
                    foreach (string linea in lineas) 
                    { 
                        AlumnoDto alumno = new AlumnoDto();
                        string[]campos= linea.Split(',');
                        alumno.IdAlumno = Utilidades.asignarId();
                        alumno.DniAlumno = campos[0];
                        alumno.NombreAlumno = campos[1];
                        Controladores.Program.listaAlumnos.Add(alumno);
                    }
                }
                else 
                {
                    Console.WriteLine("[INFO] - El fichero no existe");
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
                sw = new StreamWriter(Controladores.Program.rutaFicheroLog, true);
                sw.WriteLine(mensaje);
                sw.Close();
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
                sw = new StreamWriter(Controladores.Program.rutaFichero);
                foreach (AlumnoDto alumno in Controladores.Program.listaAlumnos)
                {
                    sw.WriteLine(alumno.ToString(';'));
                    sw.Close();
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
