using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueOnda.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required, MaxLength(12)]
        public string NombreDeUsuario { get; set; }

        [Required, MaxLength(16)]
        public string Contraseña { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required, MaxLength(200)]
        public string CorreoElectronico { get; set; }

        [MaxLength(30)]
        public string Telefono { get; set; }

        public List<Mensaje> MensajesEnviados { get; set; }
        public List<MensajesRecibidos> MensajesRecibidos { get; set; }
    }
}
