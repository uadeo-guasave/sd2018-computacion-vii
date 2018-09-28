using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        private string id;
        public string Id
        {
            get => id;
            private set => id = value;
        }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string SitioWeb { get; set; }
        public string CorreoElecronico { get; set; }
        public string UnidadRegional { get; set; }
        public bool EsExtension { get; set; }
        public List<Carrera> Carreras { get; set; }

        public Escuela(string nombre)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
            Carreras = new List<Carrera>();
        }

    }
}
