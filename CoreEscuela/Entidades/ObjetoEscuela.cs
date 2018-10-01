using System;
namespace CoreEscuela.Entidades
{
    public class ObjetoEscuela
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuela()
        {
            Id = Guid.NewGuid().ToString();
        }

        public ObjetoEscuela(string nombre)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
        }
    }
}
