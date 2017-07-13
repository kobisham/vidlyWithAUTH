using System.Collections.Generic;
 using System.Linq;
 using System.Web.Mvc;
 using vidlyWithAUTH.Models;
using System.Data.Entity;
using vidlyWithAUTH.ViewModels;

namespace vidlyWithAUTH.Controllers
 {
     public class CustomersController : Controller
     {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
         {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }
 
        public ActionResult New()
        {
            var membershipTypes = _context.MemebershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();


            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public ActionResult Edit (int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MemebershipTypes.ToList()
            };
            return View("CustomerForm",viewModel);
        }


    }
 } 