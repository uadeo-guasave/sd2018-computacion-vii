using System;
namespace CoreEscuela.Entidades
{
    public class Asignatura : ObjetoEscuela
    {
        public int Trimestre { get; set; }

        public Asignatura(string nombre, int trimestre) : base(nombre)
        {
            Trimestre = trimestre;
        }
    }
}
