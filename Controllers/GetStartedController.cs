using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace MvcSample.Web
{
    public class GetStarted : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult NewProject()
        {
            return View();
        }
    }
}