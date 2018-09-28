using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("UAdeO");
            // escuela.Id = Guid.NewGuid().ToString();
            Console.WriteLine(escuela.Id);
            Console.WriteLine(escuela.Nombre);

            var alumno = new Alumno
            {
                Nombre = "Bidkar",
                Apellidos = "Aragón Cárdenas"
            };
            Console.WriteLine("Alumno: " + alumno.NombreCompleto);

            // Arreglos
            string[] cadenas = { "cadena1", "cadena2", "cadena3" };
            Console.WriteLine(cadenas[2]);

            Carrera[] carreras = {
                new Carrera("Sistemas"),
                new Carrera("Civil"),
                new Carrera("Admon")
            };
            Console.WriteLine(carreras[1].Nombre);
        }
    }
}
