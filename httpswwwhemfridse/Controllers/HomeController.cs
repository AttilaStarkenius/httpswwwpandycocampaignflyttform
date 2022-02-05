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

        /*2.2.2022. I create a local wordpress database with help 
            of this tutorial: https://themeisle.com/blog/install-xampp-and-wordpress-locally/
        to be able to modify the code of website more than on the wordpress 
        web edit page https://wordpress.com/page/attilastarkenius.com/30
        a "critical error has occurred" is the only
        thing that I see on http://localhost/attilastarkenius/wordpress/wp-admin/setup-config.php?step=2
        so I instead edit https://wordpress.com/page/attilastarkenius.com/30 and because I still
        haven't found working input text box in wordpress I add from menu block -> form -> no specific form
        because the suggestions didn't fit now the block looks like this: Veckostädning
        Postnummer(måste anges)
        Boyta i Kvadratmeter(måste anges)
        Fyll i postnummer och boyta så får du en prisuppskattning direkt
        Kontakta oss

        I use this website to try to add 
        Wordpress project in this Visual Studio project: https://codewithmukesh.com/blog/running-wordpress-on-aspnet-core/
        I also use this site as an additional help: https://www.youtube.com/watch?v=TaixtoHZNaA&ab_channel=Hacked
        I install from php visual studio extensions. 
        */

        /*5.2.2022. I try to add
          my wordpress project to my visual studio with help of these two websites: https://codewithmukesh.com/blog/running-wordpress-on-aspnet-core/
        and: https://www.youtube.com/watch?v=TaixtoHZNaA&ab_channel=Hacked
        I install wordpress nuget package: Install-Package PeachPied.WordPress.AspNetCore -Version 5.5.1-preview1
 I commit and push with message "Install Wordpress package called PeachPied 5.2.2022."
        */

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
