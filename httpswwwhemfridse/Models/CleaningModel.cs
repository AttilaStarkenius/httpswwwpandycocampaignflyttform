using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using httpswwwhemfridse.Controllers;
using System.Collections;
using System.Drawing;
using System.Drawing.Design;
//using System.Drawing.Bitmap;
//using System.Drawing.BitmapData;
//using System.Drawing.Brush;
//using System.Drawing.Font;
//using System.Drawing.Graphics;
//using System.Drawing.Icon;
//using System.Drawing.Design;

namespace httpswwwhemfridse.Models
{
    public class CleaningModel
    {
        //6.3.2022. I use this website as help: https://softwareengineering.stackexchange.com/questions/161303/is-it-bad-practice-to-use-public-fields
        //and therefore decide to make public properties instead of public fields:
        public Image facebookImage { get; set; }

        //6.3. I get from: public Image facebookImage { get; set; }
        //though I add "using System.Drawing;"  error:
        //Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS1069  The type name 'Image' could not be found in the namespace 'System.Drawing'. 
        //This type has been forwarded to assembly 'System.Drawing.Common, Version=4.0.2.0, 
        //Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51' 
        //Consider adding a reference to that assembly.httpswwwhemfridse 
        //C:\Users\symph\source\repos\httpswwwpandycocampaignflyttform\httpswwwhemfridse
        //\Models\CleaningModel.cs	17	Active which
        //I fix with help of this website: https://stackoverflow.com/questions/37082368/cannot-see-the-image-type-in-system-drawing-namespace-in-net
        //You need to add a reference : System.Drawing.dll.
        ////In Solution Explorer, right-click on the References node and 
        ////    choose Add Reference and find System.Drawing.dll."
        ///I do: Add project references-COM-System.Drawing.dll it doesn't help
        // Nothing helps until help from this website: https://www.nuget.org/packages/System.Drawing.Common/
        // Then I can add usings: System.Drawing.Bitmap;
        //System.Drawing.BitmapData;
        //System.Drawing.Brush;
        //System.Drawing.Font;
        //System.Drawing.Graphics;
        //System.Drawing.Icon;
        //Also Design which I found myself in Drawings sublist: System.Drawing.Design;
        //Almost none of these On https://www.nuget.org/packages/System.Drawing.Common/
        //stated common usings are correct; I commit
        //and push with message "Creating CleaningModel.cs 7.3.2022."

        //7.3.2022. I continue working with https://attilastarkenius.com/stadning/
        //in the edit page https://wordpress.com/page/attilastarkenius.com/69
        //by adding two columns for Städning och fönsterputs
        //but this time both should take 50% space and also
        //delete the custom text "Använd det här utrymmet för att berätta vad som gör dina tjänster speciella."
        //because it only takes space. Now I have two 50% columns for Stadning och fönsterputs
        //part of page. I adjust text of header to center
        //and size to 40 pixels. I commit and push with message "Fix additional columns
        //in https://attilastarkenius.com/stadning/ 7.3.2022."
    }
}
