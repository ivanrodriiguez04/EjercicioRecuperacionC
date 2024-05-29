using EduRecuperacionC.Dtos;
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
                sw = new StreamWriter(Controladores.Program.rutaFichero, true);
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
