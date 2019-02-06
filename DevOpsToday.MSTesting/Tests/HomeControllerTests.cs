using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Controllers;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      // meow mix please deliver
      Assert.IsNotNull(sut.Index());
    }
  }
}