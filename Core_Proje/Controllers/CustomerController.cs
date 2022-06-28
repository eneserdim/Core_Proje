using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class CustomerController : Controller
    {
        CustomersManager customerManager = new CustomersManager(new EfCustomerDal());
        Context c = new Context();
        public IActionResult Index(Customers customers, int id)
        {
            
            ViewBag.v1 = "Cari Listesi";
            ViewBag.v2 = "Carilerim";
            ViewBag.v3 = "Cari Listesi";
            ViewBag.kar = c.Customers.Sum(x => x.AnlaşılanÜcret - x.Maliyet);
            var values = customerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            ViewBag.v1 = "Cari Ekle";
            ViewBag.v2 = "Carilerim";
            ViewBag.v3 = "Cari Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customers customers)
        {
            customers.Tarih.ToLongTimeString();
            customerManager.TAdd(customers);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            ViewBag.v1 = "Cari Güncelle";
            ViewBag.v2 = "Carilerim";
            ViewBag.v3 = "Cari Güncelle";
            var values = customerManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customers customers)
        {
            customerManager.TUpdate(customers);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var values = customerManager.GetByID(id);
            customerManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
