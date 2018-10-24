using System;
using System.Collections.Generic;
using System.Text;

namespace QueOnda.Entidades
{
    public class MensajesRecibidos
    {
        public int MensajeId { get; set; }
        public Mensaje Mensaje { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
