using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetIdentityDemoImplementation.Models;
using AspNetIdentityDemoImplementation.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentityDemoImplementation.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            MyIdentityDbContext db = new MyIdentityDbContext();

            UserStore<MyIdentityUser> userStore = new UserStore<MyIdentityUser>(db);
            UserManager<MyIdentityUser> userManager = new UserManager<MyIdentityUser>(userStore);

            MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);

            CustomerContext customerDb=new CustomerContext();
            List<Customer> model = null;

            if (userManager.IsInRole(user.Id, "Administrator"))
            {
                model = customerDb.Customers.ToList();
            }

            if (userManager.IsInRole(user.Id, "Operator"))
            {
                model = customerDb.Customers.Where(c=>c.Country=="Bangladesh").ToList();
            }

            ViewBag.FullName = user.FullName;
            return View(model);
        }

        [Authorize(Roles = "Operator")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}