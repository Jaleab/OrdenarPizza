using System.Web.Mvc;

namespace OrdenarPizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult VerArmarPizza()
        {
            return View();
        }
    }
}