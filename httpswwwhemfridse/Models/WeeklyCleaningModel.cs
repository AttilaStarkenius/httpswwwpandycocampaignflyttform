using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse.Models
{
    public class WeeklyCleaningModel
    {
        /*2.2.2022. I use this webpage as a help to use the input value that user writes
        in textboxes: https://stackoverflow.com/questions/18873098/asp-net-mvc-get-textbox-input-value
        changing from this: public class Veckostadning
    {
        /*2.2.2022. I use this webpage as a help to use the input value that user writes
        in textboxes: https://stackoverflow.com/questions/18873098/asp-net-mvc-get-textbox-input-value
        changing from this: 
        

        public string zip { get; set; }
        public string sqm { get; set; }
        */

        //to this: 
        //[Required]
        //public string zip { get; set; }
        //[Required]
        //public string sqm { get; set; }

        [Required]
        public string zip { get; set; }
        [Required]
        public string sqm { get; set; }

        //2.2.2022. Also changing view, model and controller names by conventions from:
        //    Veckostadning.cshtml, Veckostadning.cs and using same HomeController.cs to:
        //    WeeklyCleaning.cshtml, WeeklyCleaningModel.cs and create a new WeeklyCleaningController.cs
    }
}
