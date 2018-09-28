using System;
namespace CoreEscuela.Entidades
{
    public class Carrera
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Carrera(string nombre)
        {
            Nombre = nombre;
            Id = Guid.NewGuid().ToString();
        }
    }
}
