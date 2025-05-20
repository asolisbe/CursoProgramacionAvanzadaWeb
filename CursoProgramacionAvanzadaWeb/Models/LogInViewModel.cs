using CursoProgramacionAvanzadaWeb.Validators;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Models
{
    public class LogInViewModel
    {

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [MinLength(4, ErrorMessage = "El nombre de usuario debe tener al menos 4 caracteres.")]
        [LogInUserNameValidator]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
        public string? Password { get; set; }
    }

}
