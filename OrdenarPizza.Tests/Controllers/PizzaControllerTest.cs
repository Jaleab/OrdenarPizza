using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenarPizza.Controllers;

namespace OrdenarPizza.Tests.Controllers
{
    [TestClass]
    public class PizzaControllerTest
    {
        [TestMethod]
        public void VerArmarPizzaIsNotNull()
        {
            PizzaController controller = new PizzaController();

            ViewResult resultado = controller.VerArmarPizza() as ViewResult;

            Assert.IsNotNull(resultado);
        }
    }
}
