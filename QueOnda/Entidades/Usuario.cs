using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace QueOnda.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public MailAddress CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}
