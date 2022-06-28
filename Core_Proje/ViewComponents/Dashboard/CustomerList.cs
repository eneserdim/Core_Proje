using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class CustomerList : ViewComponent
    {
        CustomersManager customersManager = new CustomersManager(new EfCustomerDal());
        public IViewComponentResult Invoke()
        {
            var values = customersManager.TGetList();
            return View(values);
        }
    }
}
