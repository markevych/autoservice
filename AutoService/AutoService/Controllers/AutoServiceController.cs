using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutoService.Controllers
{
    public class AutoServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult UpdateContactInfo()
        {
            return View();
        }

        [HttpPost]
        public void UpdateContactInfo(AutoService.Models.AutoService client)
        {

        }

    }
}