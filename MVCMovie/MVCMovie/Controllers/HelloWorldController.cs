using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //index is called as the default when helloworld is called.
        //index is defined as the default in the RouteConfig file
        public ActionResult Index()
        {
            //return "This is my <strong>Default</strong> action";
            return View();  //by default will return a view with the name 
        }
        //welcome is pulled up when home/helloWorld/welcome is called
        //public string Welcome(string name, int id = 1)
        //{
        //    //HttpUtility.HtmlEncode not needed for code to work.. it is good practice to keep data more secure
        //    return HttpUtility.HtmlEncode("Hello " + name + ", Id = " + id);
        //}
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.numTimes = numTimes;
            return View();
        }
    }
}