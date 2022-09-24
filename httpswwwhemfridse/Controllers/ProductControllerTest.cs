using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using httpswwwhemfridse.Controllers;

namespace httpswwwhemfridse.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}