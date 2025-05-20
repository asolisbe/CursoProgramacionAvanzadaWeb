using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Validators
{
    public class CarroModeloValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var modelo = value as string;

            int modeloInt = Int32.Parse(modelo); 

            if (modeloInt > 2026)
            {
                return new ValidationResult("Validación personalizada, El modelo no existe");
            }

            return ValidationResult.Success;
        }
    }

}
