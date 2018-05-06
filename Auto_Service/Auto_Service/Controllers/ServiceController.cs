using Auto_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Auto_Service.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            List<Service> list = new List<Service>();
            using (ServiceContext sc = new ServiceContext())
            {
                list = sc.Services.ToList();
            }
            return View(list);
        }

        public ActionResult My()
        {
            List<Service> list = new List<Service>();
            string owner = User.Identity.GetUserName();
            using (ServiceContext sc = new ServiceContext())
            {
                list = sc.Services.Where(x => x.Owner == owner).ToList();
            }
            return View(list);
        }

        public ActionResult Manage()
        {
            List<Service> list = new List<Service>();
            using (ServiceContext sc = new ServiceContext())
            {
                list = sc.Services.ToList();
            }
            return View(list);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Service service)
        {
            using (ServiceContext sc = new ServiceContext())
            {
                sc.Services.Add(service);
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(string id)
        {
            int int_id = Convert.ToInt32(id);
            using (ServiceContext sc = new ServiceContext())
            {
                var service = sc.Services.First<Service>(x => x.Id == int_id);
                return View(service);
            }
        }

        [HttpPost]
        public ActionResult Edit(Service model)
        {
            using (ServiceContext db = new ServiceContext())
            {
                Service oldService = db.Services.First<Service>(x => x.Id == model.Id);
                
                oldService.Address = model.Address;
                oldService.Name = model.Name;
                oldService.Description = model.Description;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(string id)
        {
            int int_id = Convert.ToInt32(id);
            using (ServiceContext sc = new ServiceContext())
            {
                var service = sc.Services.First<Service>(x => x.Id == int_id);
                return View(service);
            }
        }

        public ActionResult Delete(string id)
        {
            int int_id = Convert.ToInt32(id);
            using (ServiceContext sc = new ServiceContext())
            {
                var service = sc.Services.First<Service>(x => x.Id == int_id);
                return View(service);
            }
        }

        [HttpPost]
        public ActionResult Delete(Service model)
        {
            using (ServiceContext sc = new ServiceContext())
            {
                Service service = sc.Services.First<Service>(x => x.Id == model.Id);

                sc.Services.Remove(service);
                sc.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}