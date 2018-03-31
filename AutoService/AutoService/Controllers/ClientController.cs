using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoService.Models;

namespace AutoService.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddAdvertisement()
        {
            return View();
        }

        [HttpPost]
        public void AddAdvertisement(int clientId, Advertisement advertisement)
        {

        }

        public ActionResult RegisterClient()
        {
            return View();
        }

        [HttpPost]
        public void RegisterClient(Client client)
        {

        }

        public ActionResult UpdateAdvertisement()
        {
            return View();
        }

        [HttpPost]
        public void UpdateAdvertisement(Client client)
        {

        }

        public ActionResult RemoveAdvertisement()
        {
            return View();
        }

        [HttpPost]
        public void RemoveAdvertisement(Client client)
        {

        }

        public ActionResult UpdateContactInfo()
        {
            return View();
        }

        [HttpPost]
        public void UpdateContactInfo(Client client)
        {

        }
    }
}