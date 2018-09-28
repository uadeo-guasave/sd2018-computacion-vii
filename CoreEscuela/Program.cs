using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("UAdeO");
            var sistemas = new Carrera("Sistemas computacionales");
            escuela.Carreras.Add(sistemas);
            var conta = new Carrera("Contabilidad");
            escuela.Carreras.Add(conta);
            Console.WriteLine("Escuela: " + escuela.Nombre);
            foreach (var carrera in escuela.Carreras)
            {
                Console.WriteLine("Carrera: " + carrera.Nombre);
            }

            //var comp7 = new Asignatura("Computacion VII", 7);
            //var derhum = new Asignatura("Derechos Humanos", 7);
            //sistemas.Asignaturas.Add(comp7);
            //sistemas.Asignaturas.Add(derhum);
            var materias = new List<Asignatura>
            {
                new Asignatura("Computacion VII", 7),
                new Asignatura("Derechos Humanos", 7)
            };
            sistemas.Asignaturas.AddRange(materias);
            foreach (var carrera in escuela.Carreras)
            {
                foreach (var asignatura in carrera.Asignaturas)
                {
                    Console.WriteLine($"Carrera: {carrera.Nombre} Asignatura: {asignatura.Nombre}");
                }
            }
        }
    }
}
