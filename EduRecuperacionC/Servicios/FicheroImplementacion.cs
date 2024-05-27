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
            StreamWriter sw = new StreamWriter(Controladores.Program.rutaFicheroLog,true);
            sw.Write(mensaje);
            sw.Close();
        }
    }
}
