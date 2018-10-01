using System;
namespace CoreEscuela.Entidades
{
    public class Calificacion : ObjetoEscuela
    {
        public double Nota { get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }

        public Calificacion(string nombre, Asignatura asignatura, Alumno alumno) : base()
        {

        }
    }
}
