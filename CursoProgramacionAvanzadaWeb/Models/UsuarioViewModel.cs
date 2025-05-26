using CursoProgramacionAvanzadaWeb.Validators;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacionAvanzadaWeb.Models
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Identificacion { get; set; }

        [EdadMayorQueCero(ErrorMessage = "La edad debe ser mayor a 0")]
        public int Edad { get; set; }
    }

}