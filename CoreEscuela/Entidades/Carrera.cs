using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Carrera
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; }

        public Carrera(string nombre)
        {
            Nombre = nombre;
            Id = Guid.NewGuid().ToString();
            Asignaturas = new List<Asignatura>();
        }
    }
}
