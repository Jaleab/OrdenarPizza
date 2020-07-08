using OrdenarPizza.Models;
using OrdenarPizza.Services;
using System.Web.Mvc;

namespace OrdenarPizza.Controllers
{
    public class FacturaController : Controller
    {
        public ActionResult VerFactura(PizzaModel pizza)
        {
            FacturaService servicioFactura = new FacturaService();
            FacturaModel factura = new FacturaModel();

            ViewBag.pizza = pizza;
            servicioFactura.setPrecioMasa(factura, pizza.tipoMasa);
            servicioFactura.setPrecioTamaño(factura, pizza.tamañoPizza);
            servicioFactura.setTotales(factura);                
            return View(factura);
        }
    }
}