using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenarPizza.Controllers;
using OrdenarPizza.Models;
using OrdenarPizza.Services;
using System.Web.Mvc;

namespace OrdenarPizza.Tests.Controllers
{
    [TestClass]
    public class FacturaControllerTest
    {
        [TestMethod]
        public void VerFacturaIsNotNull()
        {
            PizzaModel pizza = new PizzaModel();
            FacturaService servicioFactura = new FacturaService();
            FacturaModel factura = new FacturaModel();

            FacturaController controller = new FacturaController();

            ViewResult resultado = controller.VerFactura(pizza) as ViewResult;

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void CompraRealizadaRedirected()
        {
            FacturaController controller = new FacturaController();

            FacturaModel factura = new FacturaModel();
            var resultado = (RedirectToRouteResult)controller.CompraRealizada();

            Assert.IsTrue(resultado.RouteValues["action"].Equals("Index"));
            Assert.IsTrue(resultado.RouteValues["controller"].Equals("Home"));
        }
    }
}
