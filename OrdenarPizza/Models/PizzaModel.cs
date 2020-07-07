using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrdenarPizza.Models
{
    public class PizzaModel
    {
        [Required(ErrorMessage = "*El tipo de masa es requerido.")]
        [DisplayName("Tipo de masa")]
        public string tipoMasa { get; set; }

        [DisplayName("Descripción del tipo de masa")]
        public string descripcionTipoMasa { get; set; }

        [Required(ErrorMessage = "*El tamaño de la pizza es requerido.")]
        [DisplayName("Tamaño")]
        public string tamañoPizza { get; set; }

        [DisplayName("Medida en centimetros de la pizzza")]
        public int centimetrosPizza { get; set; }

        [Required(ErrorMessage = "*Al menos un ingrediente es requerido.")]
        [DisplayName("Ingredientes")]
        public string[] ingredientes { get; set; }

        [DisplayName("Costo de los ingredientes")]
        public double[] costoIngredientes { get; set; }
    }
}