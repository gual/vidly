using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Juan Perez", Id = 1 },
                new Customer { Name = "María Hernández", Id = 2 }
            };

        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            var viewModel = new IndexCustomersViewModels { Customers = customers };
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.Where(c => c.Id == id).FirstOrDefault();
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
    }
}