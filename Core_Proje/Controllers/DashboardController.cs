using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Codeilla Software";
            ViewBag.v2 = "Admin Paneli";
            ViewBag.v3 = "Dashboard";
            return View();
        }
    }
}
