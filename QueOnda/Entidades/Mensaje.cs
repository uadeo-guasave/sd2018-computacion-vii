using System;
using System.ComponentModel.DataAnnotations;

namespace QueOnda.Entidades
{
    public class Mensaje
    {
        public int Id { get; set; }

        [Required]
        public int ConversacionId { get; set; }
        public Conversacion Conversacion { get; set; }

        [Required]
        public string Contenido { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public int UsuarioEnviaId { get; set; }
        public Usuario UsuarioEnvia { get; set; }
    }
}
