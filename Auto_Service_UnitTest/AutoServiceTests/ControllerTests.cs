using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Auto_Service;
using Auto_Service.Controllers;
using Auto_Service.Models;

namespace AutoServiceTests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Contact() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexOrder()
        {
            OrderController controller = new OrderController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageOrder()
        {
            OrderController controller = new OrderController();
            ViewResult result = controller.Manage() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateOrder()
        {
            OrderController controller = new OrderController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
