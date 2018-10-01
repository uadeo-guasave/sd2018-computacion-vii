using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuela
    {
        public string Matricula { get; set; }
        public string Apellidos { get; set; }
        public string Curp { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreCompleto
        {
            get => Nombre + " " + Apellidos;
        }
        public List<Calificacion> Calificaciones { get; set; }

        public Alumno(string nombre, string apellidos) : base()
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Calificaciones = new List<Calificacion>();
        }

    }
}
