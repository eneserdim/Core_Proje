using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 :ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Customers.Count();
            ViewBag.v2 = c.Customers.Sum(x => x.AnlaşılanÜcret-x.Maliyet);
            ViewBag.v3 = c.Customers.Sum(x => x.Maliyet);

            ViewBag.v4 = c.Experiences.Count();
            return View();
        }
    }
}
