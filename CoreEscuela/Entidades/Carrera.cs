using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Carrera : ObjetoEscuela
    {
        public List<Asignatura> Asignaturas { get; set; }

        public Carrera(string nombre) : base(nombre)
        {
            Asignaturas = new List<Asignatura>();
        }
    }
}
