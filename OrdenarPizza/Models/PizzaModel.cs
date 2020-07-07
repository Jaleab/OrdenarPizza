using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrdenarPizza.Models
{
    public class PizzaModel
    {
        [Required(ErrorMessage = "*El tipo de masa es requerido.")]
        [DisplayName("Tipo de masa")]
        private string TipoMasa { get; set; }

        [DisplayName("Descripción del tipo de masa")]
        private string descripcionTipoMasa { get; set; }

        [Required(ErrorMessage = "*El tamaño de la pizza es requerido.")]
        [DisplayName("Tamaño")]
        private string tamañoPizza { get; set; }

        [DisplayName("Medida en centimetros de la pizzza")]
        private int centimetrosPizza { get; set; }

        [Required(ErrorMessage = "*Al menos un ingrediente es requerido.")]
        [DisplayName("Ingredientes")]
        private string[] ingredientes { get; set; }

        [DisplayName("Costo de los ingredientes")]
        private double[] costoIngredientes { get; set; }
    }
}