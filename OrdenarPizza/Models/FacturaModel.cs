using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrdenarPizza.Models
{
    public class FacturaModel
    {
        [DisplayName("Precio tipo masa:")]
        public double precioTipoMasa { get; set; }

        [DisplayName("Precio tamaño de la pizza:")]
        public double precioTamaño { get; set; }

        [DisplayName("Subtotal:")]
        public double subtotal { get; set; }

        [DisplayName("Impuesto:")]
        public double costoImpuesto { get; set; }

        [DisplayName("Total:")]
        public double costoTotal { get; set; }
    }
}