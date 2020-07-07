using OrdenarPizza.Models;
using System.Web.Mvc;

namespace OrdenarPizza.Controllers
{
    public class FacturaController : Controller
    {
        public ActionResult VerFactura(PizzaModel pizza)
        {
            return View(pizza);
        }
    }
}