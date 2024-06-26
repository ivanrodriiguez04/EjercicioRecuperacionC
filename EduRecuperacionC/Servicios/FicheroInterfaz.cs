﻿using System;
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

        /// <summary>
        /// Metodo que guarda la lista alumnos en un fichero
        /// irodhan -> 29/05/2024
        /// </summary>
        public void guardarLista();

        /// <summary>
        /// metodo que hace una carga inicial del fichero
        /// irodhan -> 03/06/2024
        /// </summary>
        public void cargaInicial();
    }
}
