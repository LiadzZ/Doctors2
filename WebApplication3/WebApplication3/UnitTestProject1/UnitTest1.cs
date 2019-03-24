using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3.Controllers;
using System.Web.Mvc;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController();
            ViewResult vr = controller.Contact() as ViewResult; 
            Assert.AreEqual("Your contact page.",vr.ViewBag.Message);
        }
    }
}
