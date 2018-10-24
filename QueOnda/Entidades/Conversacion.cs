using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QueOnda.Entidades
{
    public class Conversacion
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Titulo { get; set; }

        [Required]
        public bool EsGrupal { get; set; }
    }
}
