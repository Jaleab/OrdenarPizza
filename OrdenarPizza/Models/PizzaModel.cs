using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrdenarPizza.Models
{
    public class PizzaModel
    {
        [Required(ErrorMessage = "*El tipo de masa es requerido.")]
        [DisplayName("Tipo de masa")]
        public string tipoMasa { get; set; }

        [Required(ErrorMessage = "*El tamaño de la pizza es requerido.")]
        [DisplayName("Tamaño")]
        public string tamañoPizza { get; set; }

        [Required(ErrorMessage = "*La salsa de la pizza es requerida.")]
        [DisplayName("Salsa")]
        public string salsa { get; set; }

        [Required(ErrorMessage = "*El queso de la pizza es requerido.")]
        [DisplayName("Queso")]
        public string queso { get; set; }

        [Required(ErrorMessage = "*Al menos un ingrediente es requerido.")]
        [DisplayName("Ingredientes")]
        public string[] ingredientes { get; set; }
    }
}