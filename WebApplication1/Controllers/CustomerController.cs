using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> customers;
        public CustomerController()
        {
            customers= new List<Customer>
            {
                new Customer{Id = 1, Name = "Mosh"},
                new Customer{Id =2, Name="Bob"}
            };
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customersList = new CustomerViewModel
            {
                Customers = customers
            };

            return View(customersList);
        }


        [Route("customer/viewdetail/{id:regex(\\d{1}):range(1,2)}")]
        public ActionResult ViewDetail(int id)
        {
            var customer = customers.Find(c => c.Id == id);

            return View(customer);
        }
    }
}