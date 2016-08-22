using Entities;
using Interfaces;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WepApp.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepository _customerRepository = new CustomerRepository();
        // GET: Customer
        public ActionResult Index()
        {
            return View(_customerRepository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
           _customerRepository.Create(customer);
            return RedirectToAction("Index");
        }
    }
}