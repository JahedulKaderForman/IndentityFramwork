using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZoooApp.MvcClient.Controllers
{
    public class Animal1Controller : Controller
    {
        //
        // GET: /Animal1/
        public ActionResult Index()
        {
            AnimalService service = new AnimalService();
        }
	}
}