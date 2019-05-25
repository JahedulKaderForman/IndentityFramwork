using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityCreateNewUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "formankhan2014@gmail.com";
            var password = "Forman1234";
            var userStore=new UserStore<IdentityUser>();
            var userManger=new UserManager<IdentityUser>(userStore);

            //var creationResult=userManger.Create(new IdentityUser("formankhan2014@gmail.com"), "Forman1234");
            //Console.WriteLine("Created: {0}",creationResult.Succeeded);
            var user = userManger.FindByName(username);
           // var claimResult = userManger.AddClaim(user.Id, new Claim("Forman", "khan"));
            //Console.WriteLine("claim: {0}", claimResult.Succeeded);
            var isMatch = userManger.CheckPassword(user, password);
            Console.WriteLine("password Match: {0}", isMatch);
            Console.ReadKey();
        }
    }
}
