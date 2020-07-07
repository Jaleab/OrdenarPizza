using OrdenarPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult OrdenarPizza(PizzaModel pizza, string[] tipoMasa) {
            return View(pizza);
        }
    }
}