using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentityDemoImplementation.Security
{
    public class MyIdentityDbContext:IdentityDbContext<MyIdentityUser>
    {
        public MyIdentityDbContext() : base("connectionstring")
        {
            
        }
    }
   
}