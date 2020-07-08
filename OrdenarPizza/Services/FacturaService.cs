using OrdenarPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrdenarPizza.Services
{
    public class FacturaService
    {
        public void setPrecioMasa(FacturaModel factura, string tipoMasa) {
            if (tipoMasa != null) {
                switch (tipoMasa) {
                    case "Original":
                        factura.precioTipoMasa = 0.00;
                        break;
                    case "Al sartén":
                        factura.precioTipoMasa = 1.99;
                        break;
                    case "Crunchy":
                        factura.precioTipoMasa = 3.99;
                        break;
                    case "Borde con queso":
                        factura.precioTipoMasa = 4.99;
                        break;

                }
            }
        }

        public void setPrecioTamaño(FacturaModel factura, string tamaño)
        {
            if (tamaño != null)
            {
                switch (tamaño)
                {
                    case "Mediana":
                        factura.precioTamaño = 7.99;
                        break;
                    case "Grande":
                        factura.precioTamaño = 11.99;
                        break;
                    case "Jumbo":
                        factura.precioTamaño = 15.99;
                        break;
                }
            }
        }

        public void setTotales(FacturaModel factura)
        {
            if (factura != null)
            {
                factura.subtotal = factura.precioTipoMasa + factura.precioTamaño ;
                factura.costoImpuesto = factura.subtotal * 0.130;
                factura.costoTotal = factura.subtotal + factura.costoImpuesto;
            }
        }
    }
}