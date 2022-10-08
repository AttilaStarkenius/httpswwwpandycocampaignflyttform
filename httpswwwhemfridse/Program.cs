using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse
{
    //5.10.2022. I commit and push with message: "5.10.2022. Adding public class BankAccount as a part of unit test tutorial"

    //7.10.2022. When I run the project I come to page https://localhost:44379/ and get this
    //    message: HTTP Error 500.30 - ANCM In-Process Start Failure
    //    Common solutions to this issue:
    //The application failed to start
    //    The application started but then stopped
    //    The application started but threw an exception during startup
    //    Troubleshooting steps:
    //Check the system event log for error messages
    //    Enable logging the application process' stdout messages
    //Attach a debugger to the application process and inspect
    //    For more information visit: https://go.microsoft.com/fwlink/?LinkID=2028265
    // I use the tutorial https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
    //I follow the instruction "Rename the file to BankAccount.cs by right-clicking
    //and choosing Rename in Solution Explorer.
    //Then I add unit test project BankTests 
    //In the BankTests project, add a reference to the Bank project
    //like this: In Solution Explorer, select Dependencies under
    //the BankTests project and then choose Add Reference
    //(or Add Project Reference) from the right-click menu.
    // I notice I haven't added the project "Bank" so I do it:
    //Search for and select the C# Console App project template for .NET Core, and then click Next.
    //  Note   If you do not see the Console App template, you can install it from the Create a new project window.In the Not finding what you're looking for? message, choose the Install more tools and features link. Then, in the Visual Studio Installer, choose the .NET Core cross-platform development workload.
    //Name the project Bank, and then click Next.
    // Choose either the recommended target framework or.NET 6, and then choose Create.
    //      The Bank project is created and displayed in Solution Explorer with the Program.cs file open in the code editor.



    //    // <summary>
    //    // Bank account demo class.
    //    // </summary>

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
    //6.10.2022. When I run project I get error: "Severity	Code	Description	Project	File	Line	Suppression State
    //Error CS8400	Feature 'top-level statements' is not available in C# 8.0. Please use language version 9.0 or greater.	httpswwwhemfridse	C:\Users\Attila\source\repos\httpswwwpandycocampaignflyttform\httpswwwhemfridse\Program.cs	77	Active
    //" so I comment out " and space"


    //"

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
