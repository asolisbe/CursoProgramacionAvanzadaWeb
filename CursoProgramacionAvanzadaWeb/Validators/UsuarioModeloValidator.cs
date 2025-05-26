using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Validators
{
    public class EdadMayorQueCeroAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int edad && edad <= 0)
            {
                return new ValidationResult(ErrorMessage ?? "Edad no válida");
            }

            return ValidationResult.Success;
        }
    }
}
