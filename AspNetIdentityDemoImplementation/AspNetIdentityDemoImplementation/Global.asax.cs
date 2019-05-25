using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AspNetIdentityDemoImplementation.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentityDemoImplementation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MyIdentityDbContext db=new MyIdentityDbContext();
            RoleStore<MyIdentityRole>roleStore=new RoleStore<MyIdentityRole>(db);
            RoleManager<MyIdentityRole>roleManager=new RoleManager<MyIdentityRole>(roleStore);

            if (!roleManager.RoleExists("Administrator"))
            {
                MyIdentityRole newRole = new MyIdentityRole("Administrator", "Administrators can add, edit and delete data.");
                roleManager.Create(newRole);
            }

            if (!roleManager.RoleExists("Operator"))
            {
                MyIdentityRole newRole = new MyIdentityRole("Operator", "Operators can only add or edit data.");
                roleManager.Create(newRole);
            }



        }
    }
}
