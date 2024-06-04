using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    /// <summary>
    /// Clase que contiene la informacion de los alumnos
    /// irodhan -> 27/05/2024
    /// </summary>
    internal class AlumnoDto
    {
        //Atributos
        private long idAlumno;
        private string nombreAlumno="aaaaa";
        private string apellido1Alumno = "aaaaa";
        private string apellido2Alumno = "aaaaa";
        private string dniAlumno = "aaaaa";
        private string direccionAlumno = "aaaaaa";
        private int telefonoAlumno = 0;
        private string emailAlumno = "aaaaa";
        private DateTime fchNacimientoAlumno = DateTime.Now;

        //Constructores
        public AlumnoDto() 
        { }


        //Getters & Setters
        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Apellido1Alumno { get => apellido1Alumno; set => apellido1Alumno = value; }
        public string Apellido2Alumno { get => apellido2Alumno; set => apellido2Alumno = value; }
        public string DniAlumno { get => dniAlumno; set => dniAlumno = value; }
        public string DireccionAlumno { get => direccionAlumno; set => direccionAlumno = value; }
        public int TelefonoAlumno { get => telefonoAlumno; set => telefonoAlumno = value; }
        public string EmailAlumno { get => emailAlumno; set => emailAlumno = value; }
        public DateTime FchNacimientoAlumno { get => fchNacimientoAlumno; set => fchNacimientoAlumno = value; }

        override
        //ToString
        public string ToString() 
        {
            string concatenacion =string.Concat(this.DniAlumno," - ",this.NombreAlumno);
            return concatenacion;
        }
        public string ToString(char caracter)
        {
            string concatenacion = string.Concat(this.IdAlumno,caracter, this.NombreAlumno,caracter,this.Apellido1Alumno, caracter, this.Apellido2Alumno, caracter,this.DniAlumno, caracter, this.DireccionAlumno, caracter, this.TelefonoAlumno, caracter, this.EmailAlumno, caracter, this.fchNacimientoAlumno.ToString("dd/MM/yyyy"));
            return concatenacion;
        }
    }
}
