using httpswwwhemfridse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Also Homecontroller.cs just returns views which is not a lot for a controller in a MVC application.
        //    I create IActionResult Veckostadning, just like there is similar Index and
        //    Privacy methods: public IActionResult Veckostadning()
        //    {
        //        return View();
        //}

        //public IActionResult Veckostadning()
        //    {
        //        return View();
        //    }
        //2.2.2022. I think the issue is
        //this I change in HomeController from: public IActionResult Veckostadning()

        //            {
        //        return View();
        //}
        //to:  public IActionResult WeeklyCleaning()
        //{
        //    return View();
        //}
        //It works, even though this site doesn't work:https://localhost:44379/WeeklyCleaning/WeeklyCleaning
        //this site works: https://localhost:44379/Home/WeeklyCleaning
        //I also try to pass values from WeeklyCleaning.cshtml
        //that user inputs by changing from:  public IActionResult WeeklyCleaning()
        //    {
        //        return View();
        //}
        //to: [HttpPost]
        //public IActionResult WeeklyCleaning(WeeklyCleaningModel model)
        //{
        //    return View();
        //}
        //2.2.2022. I commit all and push with message "Fixing Models, Views and Controllers
        //for https://localhost:44379/Home/WeeklyCleaning 2.2.2022."
        [HttpPost]
        public IActionResult WeeklyCleaning(WeeklyCleaningModel model)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
