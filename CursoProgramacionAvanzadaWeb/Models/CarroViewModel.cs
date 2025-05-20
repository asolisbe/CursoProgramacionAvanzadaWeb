using CursoProgramacionAvanzadaWeb.Validators;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Models
{
    public class CarroViewModel
    {
        [Required(ErrorMessage = "La marca del carro es  requerida")]
        public string? marca { get; set; }

        [CarroModeloValidator]
        public string? modelo { get; set; }
    }
}
