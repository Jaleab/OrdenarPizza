using OrdenarPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrdenarPizza.Services
{
    public class Factura
    {
        public void setPrecioMasa(FacturaModel factura, string tipoMasa) {
            if (tipoMasa != null) {
                switch (tipoMasa) {
                    case "Al sartén":
                        factura.precioTipoMasa = 1.99;
                        break;
                    case "Crunchy":
                        factura.precioTipoMasa = " ";
                        break;
                    case "Borde con queso":
                        factura.precioTipoMasa = " ";
                        break;

                }
            }
        }
    }
}