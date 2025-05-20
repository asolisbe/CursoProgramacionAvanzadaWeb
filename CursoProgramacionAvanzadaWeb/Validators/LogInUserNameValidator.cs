using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Validators
{
    public class LogInUserNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userName = value as string;

            // Si el valor es nulo o vacío, no valida aquí (deja que [Required] lo maneje)
            if (string.IsNullOrEmpty(userName))
            {
                return ValidationResult.Success;
            }

            if (userName.Length > 8)
            {
                return new ValidationResult("Validación personalizada, Usuario muy largo");
            }

            return ValidationResult.Success;
        }
    }

}
