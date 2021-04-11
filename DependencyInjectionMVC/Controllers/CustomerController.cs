using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerServices;

namespace DependencyInjectionMVC.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _iCustomerService;

        public CustomerController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        // GET: Customer
        public ActionResult GetCustomers()
        {
            return Json(_iCustomerService.GetCustomers(), JsonRequestBehavior.AllowGet);
        }
    }
}