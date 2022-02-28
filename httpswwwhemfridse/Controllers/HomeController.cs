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

        /*5.2.2022. I continue to edit wordpress site https://attilastarkenius.com/
        in the edit page https://wordpress.com/page/attilastarkenius.com/2 
        by trying to add menu with help of this website: 
        https://www.wpbeginner.com/beginners-guide/how-to-add-navigation-menu-in-wordpress-beginners-guide/
        First I go to the https://attilastarkenius.wordpress.com/wp-admin/nav-menus.php page,
        then add Menu with name Top Navigation Menu, and then "Save Menu"
        and then edit settings in https://attilastarkenius.wordpress.com/wp-admin/nav-menus.php?action=edit&menu=1372324
        like: Check "Add automatically new pages with the menu"
        and check also all existing pages and "Save Menu". I commit and push with
        message "Add Wordpress menu to attilastarkenius.com 5.2.2022.*/

        /*7.2.2022. Now there is the menu
        I made and https://attilastarkenius.com/ looks like this: 
        WEBBPLATSRUBRIK Hem Veckostädning and https://attilastarkenius.com/veckostadning/
        has the same menu. I am about to add things like "Så hanterar vi covid-19"-menu
        which I do by going to: https://attilastarkenius.wordpress.com/wp-admin/nav-menus.php
        and "Create a menu" and give it a name "covid-19" and check 
        "automatically add pages to this menu" and click "Create the menu".
        Then, now that the menu is created, I add "custom link" https://www.hemfrid.se/covid-19
        with the link text: Så hanterar vi covid-19 
        Because that menu doesn't show up I go to https://attilastarkenius.wordpress.com/wp-admin/nav-menus.php?menu=1372326
        "add to every page" and save menu. Because still nothing shows up
        I go to https://attilastarkenius.wordpress.com/wp-admin/nav-menus.php?action=locations
        There is text "Your theme supports only 2 menus. Please choose: Primary navigation or Social navigation
        so I save "covid-19" as Social navigation. Now
        https://attilastarkenius.com/ looks like this: WEBBPLATSRUBRIK
        Hem
        Veckostädning
        with an image xmlns="http://www.w3.org/2000/svg" with links leading 
        to https://attilastarkenius.com/, https://attilastarkenius.com/veckostadning/ and
        https://www.hemfrid.se/covid-19. I commit and push with message
        "Add covid-19 menu to https://attilastarkenius.com/ 7.2.2022."*/

        /*18.2.2022. When I run the project I come
         to page https://localhost:44379/ which has a menu
        that looks like this: httpswwwhemfridse Home Privacy
        I try to change it to similar to Hemfrid.se like this:
Städning
Veckostädning Storstädning Flyttstädning Fönsterputs Kontorsstädning

Flytt
Flytthjälp Flyttstädning Enklare hantverk Återvinning Kontorsflytt

Trädgård
Trädgårdshjälp Trädbeskärning

Omsorg
Vardagsomsorg

För företag
För bostadsrättsföreningar Kontorsstädning Kontorsflytt Löneförmån

Här finns vi
Stockholm Göteborg Malmö Uppsala Västerås Linköping & Norrköping
Om Hemfrid
Vanliga frågor Kontakt Jobba hos oss Hållbarhet Rutavdrag Hemfrids app
Beställ städning so I
go to Views\Shared\_Layout.cshtml file and edit there*/


        //[HttpPost]
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
