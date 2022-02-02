using httpswwwhemfridse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse.Controllers
{
    public class WeeklyCleaningController : Controller
    {
        [HttpPost]
        public IActionResult WeeklyCleaning(WeeklyCleaningModel model)
        {
            return View();
        }
    }
}
