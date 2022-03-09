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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System;
using System.Net;
using System.IO;

namespace httpswwwhemfridse.Models
{
    public class CleaningModel
    {

        public Image facebookProfilePicture { get; set; }
        public string firstName { get; set; }



        //9.3.2022. I move the webclient code to Homecontroller.cs classes
        //    public IActionResult Privacy() action method the code I move looks like this: 



        //    WebClient client = new WebClient();

        //        client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

        //        // Download data.
        //        byte[] arr = client.DownloadData("http://www.dotnetperls.com/");

        //// Write values.
        //Console.WriteLine("--- WebClient result ---");
        //        Console.WriteLine(arr.Length);

        //        using (WebClient webClient = new WebClient())
        //{
        //    byte[] data = webClient.DownloadData("https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9");

        //   using (MemoryStream mem = new MemoryStream(data)) 
        //   {
        //       using (var yourImage = Image.FromStream(mem)) 
        //       { 
        //          // If you want it as Png
        //           yourImage.Save("path_to_your_file.png", ImageFormat.Png) ; 

        //          // If you want it as Jpeg
        //           yourImage.Save("path_to_your_file.jpg", ImageFormat.Jpeg) ; 
        //       }
        //   } 

        //}

        //}


        //6.3.2022. I use this website as help: https://softwareengineering.stackexchange.com/questions/161303/is-it-bad-practice-to-use-public-fields
        //and therefore decide to make public properties instead of public fields:
        /*9.3.2022.         public Image facebookImage { get; set; }
        gives me error: Severity	Code	Description	Project	File	Line	Suppression State
        Error	CS1513	} expected	httpswwwhemfridse	C:\Users\symph\source\repos\httpswwwpandycocampaignflyttform\httpswwwhemfridse\Models\CleaningModel.cs	29	Active


        /*9.3.2022. I continue working with visual studio CleaningModel.cs
        by noticing while inspecting page in https://www.hemfrid.se/stadning that the facebook image
        in chatbox, when logged in via Facebook, is jpg image here is whole link to image: 
        https://scontent-arn2-1.xx.fbcdn.net/v/t39.30808-1/271976368_10224722170354716_5953490547982226678_n.jpg?stp=c0.8.50.50a_cp0_dst-jpg_p50x50&_nc_cat=104&ccb=1-5&_nc_sid=bbed71&_nc_ohc=AaohApX2LuQAX-4zbsm&_nc_ht=scontent-arn2-1.xx&oh=00_AT_1GIvUYyj0Cdgl8Bsn8QOz4e27XimkvG35iBzSMMIvSA&oe=622CC622
        I try to convert the webpage to image
        with help of this site: https://stackoverflow.com/questions/2715385/convert-webpage-to-image-from-asp-net
        like this: "using System.Drawing;
        using System.Drawing.Imaging;
        using System.IO;
        using System.Threading;
        using System.Windows.Forms;

        public class WebsiteToImage
        {
        private Bitmap m_Bitmap;
        private string m_Url;
        private string m_FileName = string.Empty;

        public WebsiteToImage(string url)
        {
        // Without file 
        m_Url = url;
        }

        public WebsiteToImage(string url, string fileName)
        {
        // With file 
        m_Url = url;
        m_FileName = fileName;
        }

        public Bitmap Generate()
        {
        // Thread 
        var m_thread = new Thread(_Generate);
        m_thread.SetApartmentState(ApartmentState.STA);
        m_thread.Start();
        m_thread.Join();
        return m_Bitmap;
        }

        private void _Generate()
        {
        var browser = new WebBrowser { ScrollBarsEnabled = false };
        browser.Navigate(m_Url);
        browser.DocumentCompleted += WebBrowser_DocumentCompleted;

        while (browser.ReadyState != WebBrowserReadyState.Complete)
        {
            Application.DoEvents();
        }

        browser.Dispose();
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        // Capture 
        var browser = (WebBrowser)sender;
        browser.ClientSize = new Size(browser.Document.Body.ScrollRectangle.Width, browser.Document.Body.ScrollRectangle.Bottom);
        browser.ScrollBarsEnabled = false;
        m_Bitmap = new Bitmap(browser.Document.Body.ScrollRectangle.Width, browser.Document.Body.ScrollRectangle.Bottom);
        browser.BringToFront();
        browser.DrawToBitmap(m_Bitmap, browser.Bounds);

        // Save as file? 
        if (m_FileName.Length > 0)
        {
            // Save 
            m_Bitmap.SaveJPG100(m_FileName);
        }
        }
        }

        public static class BitmapExtensions
        {
        public static void SaveJPG100(this Bitmap bmp, string filename)
        {
        var encoderParameters = new EncoderParameters(1);
        encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
        bmp.Save(filename, GetEncoder(ImageFormat.Jpeg), encoderParameters);
        }

        public static void SaveJPG100(this Bitmap bmp, Stream stream)
        {
        var encoderParameters = new EncoderParameters(1);
        encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
        bmp.Save(stream, GetEncoder(ImageFormat.Jpeg), encoderParameters);
        }

        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {
        var codecs = ImageCodecInfo.GetImageDecoders();

        foreach (var codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }

        // Return 
        return null;
        }
        }And can call it as follows:

        WebsiteToImage websiteToImage = new WebsiteToImage( "http://www.cnn.com", @"C:\Some Folder\Test.jpg");
        websiteToImage.Generate();
        It works with both a file and a stream. Make sure you add a reference to System.Windows.Forms to your ASP.NET project"

        so I begin with adding a reference to System.Windows.Forms
        by in Solution Explorer right click httpswwhemfridse -> add COM reference -> System_Windows_Forms
        and then add in CleaningModel.cs: using System.Drawing;
        using System.Drawing.Imaging;
        using System.IO;
        using System.Threading;
        using System.Windows.Forms;
        then I get error: Severity	Code	Description	Project	File	Line	Suppression State
        Error	CS0234	The type or namespace name 'Forms' does not exist in the namespace 'System.Windows' (are you missing an assembly reference?)	httpswwwhemfridse	C:\Users\symph\source\repos\httpswwwpandycocampaignflyttform\httpswwwhemfridse\Models\CleaningModel.cs	20	Active
        and when I try in package manager console: Install-Package System.Windows.Forms
        I get error: Install-Package : Unable to find package 'System.Windows.Forms'
        At line:1 char:1
        + Install-Package System.Windows.Forms
        + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
        + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand
        so instead of https://stackoverflow.com/questions/2715385/convert-webpage-to-image-from-asp-net
        I try use this website: https://www.codegrepper.com/code-examples/csharp/how+to+extract+images+from+website+c%23
        by adding this: using (WebClient webClient = new WebClient()) 
        {
        byte [] data = webClient.DownloadData("https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9");

        using (MemoryStream mem = new MemoryStream(data)) 
        {
        using (var yourImage = Image.FromStream(mem)) 
        { 
          // If you want it as Png
           yourImage.Save("path_to_your_file.png", ImageFormat.Png) ; 

          // If you want it as Jpeg
           yourImage.Save("path_to_your_file.jpg", ImageFormat.Jpeg) ; 
        }
        } 

        }
        so I add: using (WebClient client = new WebClient())
                {
                    client.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                    // Download data.
                    byte[] arr = client.DownloadData("http://www.dotnetperls.com/");

                    // Write values.
                    Console.WriteLine("--- WebClient result ---");
                    Console.WriteLine(arr.Length);
                }
        it doesn't work either so I just try to use javascript with this web page: https://stackoverflow.com/questions/50911100/c-sharp-net-scraping-dynamic-js-websites
        like installing Install-Package ScrapySharp -Version 3.0.0 in package manage console
        I commit and push with message "Trying to use ScrapySharp 9.3.2022."*/


    }
}

//        using (WebClient webClient = new WebClient())
//{
//    byte[] data = webClient.DownloadData("https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9");

//   using (MemoryStream mem = new MemoryStream(data)) 
//   {
//       using (var yourImage = Image.FromStream(mem)) 
//       { 
//          // If you want it as Png
//           yourImage.Save("path_to_your_file.png", ImageFormat.Png) ; 

//          // If you want it as Jpeg
//           yourImage.Save("path_to_your_file.jpg", ImageFormat.Jpeg) ; 
//       }
//   } 

//}

//}

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
    