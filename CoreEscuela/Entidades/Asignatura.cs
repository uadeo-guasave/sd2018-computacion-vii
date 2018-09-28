using System;
namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Trimestre { get; set; }

        public Asignatura(string nombre, int trimestre)
        {
            Nombre = nombre;
            Trimestre = trimestre;
            Id = Guid.NewGuid().ToString();
        }
    }
}
