using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using System.Linq;

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

            string[] nombres = { "Juan", "Maria", "Jose", "Pedro", "Guadalupe" };
            string[] paternos = { "Lopez", "Beltran", "Leyva", "Bon", "Leon" };
            string[] maternos = { "Quintero", "Gaxiola", "Garcia", "Castro", "Sandoval" };

            //foreach (var nombre in nombres)
            //{
            //    foreach (var paterno in paternos)
            //    {
            //        foreach (var materno in maternos)
            //        {
            //            Console.WriteLine($"{nombre} {paterno} {materno}");
            //        }
            //    }
            //}
            IEnumerable<Alumno> als = from nombre in nombres
                                          from paterno in paternos
                                          from materno in maternos
                select new Alumno(nombre, $"{paterno} {materno}");

            var alumnos = als.OrderBy(alumno => alumno.Id).Take(20).ToList();

            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno.Id + " " + alumno.NombreCompleto);
            }
        }
    }
}
