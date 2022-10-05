using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using httpswwwhemfridse.Controllers;

namespace httpswwwhemfridse.Controllers
{
    [TestClass]
    //5.10.2022. When I run the project I get error: "Severity	Code	Description	Project	File	Line	Suppression State
    //Error CS0234  The type or namespace name 'TestTools' does not exist in the namespace 'Microsoft.VisualStudio' 
    //    (are you missing an assembly reference?)	
    //    httpswwwhemfridse C:\Users\Attila\source\repos\httpswwwpandycocampaignflyttform\httpswwwhemfridse\
    //    Controllers\ProductControllerTest.cs	2	Active
    // with the help of website https://learn.microsoft.com/en-us/answers/questions/287215/identifying-project-templates-visual-studio-2019.html
    //I find out my project is .NET Core 3.1 Console Application so I can use
    //    the tutorial in this website: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
    //in Program.cs I replace this: "namespace httpswwwhemfridse
    //{
    //    public class Program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            CreateHostBuilder(args).Build().Run();
    //        }

    //        public static IHostBuilder CreateHostBuilder(string[] args) =>
    //            Host.CreateDefaultBuilder(args)
    //                .ConfigureWebHostDefaults(webBuilder =>
    //                {
    //                    webBuilder.UseStartup<Startup>();
    //                });
    //    }
    //}
    //"
    //with this: "{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
//    public class BankAccount
//    {
//        private readonly string m_customerName;
//        private double m_balance;

//        private BankAccount() { }

//        public BankAccount(string customerName, double balance)
//        {
//            m_customerName = customerName;
//            m_balance = balance;
//        }

//        public string CustomerName
//        {
//            get { return m_customerName; }
//        }

//        public double Balance
//        {
//            get { return m_balance; }
//        }

//        public void Debit(double amount)
//        {
//            if (amount > m_balance)
//            {
//                throw new ArgumentOutOfRangeException("amount");
//            }

//            if (amount < 0)
//            {
//                throw new ArgumentOutOfRangeException("amount");
//            }

//            m_balance += amount; // intentionally incorrect code
//        }

//        public void Credit(double amount)
//        {
//            if (amount < 0)
//            {
//                throw new ArgumentOutOfRangeException("amount");
//            }

//            m_balance += amount;
//        }

//        public static void Main()
//        {
//            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

//            ba.Credit(5.77);
//            ba.Debit(11.22);
//            Console.WriteLine("Current balance is ${0}", ba.Balance);
//        }
//    }
//}
//"
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}