using System;
namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string Id { get; private set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Curp { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreCompleto
        {
            get => Nombre + " " + Apellidos;
        }

        public Alumno()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
