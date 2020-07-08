using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrdenarPizza.Models
{
    public class FacturaModel
    {
        [Required(ErrorMessage = "*El cantón es requerido.")]
        [DisplayName("Cantón")]
        public string canton { get; set; }

        [Required(ErrorMessage = "*La provincia es requerida.")]
        [DisplayName("Provincia")]
        public string provincia { get; set; }

        [Required(ErrorMessage = "*El número de teléfono es requerido.")]
        [DisplayName("Número de teléfono")]
        public string numeroTelefónico { get; set; }

        [DisplayName("Total:")]
        public string costoTotal { get; set; }

        [DisplayName("Impuesto:")]
        public string costoImpuesto { get; set; }

        [DisplayName("Subtotal:")]
        public string subtotal { get; set; }
    }
}