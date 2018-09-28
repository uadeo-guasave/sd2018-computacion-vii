using System;
namespace CoreEscuela.Entidades
{
    public class Calificacion
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }

        public Calificacion()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
