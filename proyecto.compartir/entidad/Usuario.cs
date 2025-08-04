using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.compartir.entidad
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellidos { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Carnet { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Correo { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Login { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Password { get; set; } = null!;


    }
}
 