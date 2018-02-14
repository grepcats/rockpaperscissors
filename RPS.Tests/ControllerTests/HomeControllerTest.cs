using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;
using RPS.Controllers;

namespace RPS.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();

      //
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;

      //
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
  }
}
