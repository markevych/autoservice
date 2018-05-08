using Auto_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auto_Service.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOwnersOfCar(string carName)
        {
            List<Order> list = new List<Order>();
            using (OrdersContext sc = new OrdersContext())
            {
                list = sc.Orders.Where(x => x.CarName == carName).ToList();
            }
            return View(list);
        }
    }
}