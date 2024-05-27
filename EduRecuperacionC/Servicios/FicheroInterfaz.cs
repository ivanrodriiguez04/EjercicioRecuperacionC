using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Metodo que escribe en el fichero log 
        /// irodhan -> 27/05/2024
        /// </summary>
        public void escribirFicheroLog(string mensaje);
    }
}
