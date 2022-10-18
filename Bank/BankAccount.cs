// <summary>
// Bank account demo class.
// </summary>

//8.10.2022. I use the tutorial 
//https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
//When I run the project I come to Microsoft Visual Studio Debug Console with output:
//Current balance is $28,979999999999997
//C: \Users\Attila\source\repos\httpswwwpandycocampaignflyttform\Bank\bin\Debug\netcoreapp3 .1\Bank.exe(process 13172) exited with code 0.
//Press any key to close this window . . .
// I commit and push with message "8.10.2022. Debugging BankAccount.cs"

//18.10.2022. I try to do quick run through of .NET so first I 
// * use this tutorial: https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create
// * I create a Blazor server app called "BlazorApp" and set it as a startup project.
// * I run the app https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/run
// * I come to page https://localhost:44344/
// * that looks like this: "BlazorApp
//Home
//Counter
//Fetch data
//About
//Hello, world!
//Welcome to your new app.
// How is Blazor working for you? Please take our brief survey and tell us what you think."
//in https://localhost:44344/counter I click "Click me" button
//like instructed here: https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/try
//and the Current count: 0 is updated to Current count: 1 without
//refreshing the page. 


//using System;

//namespace Bank
//{

//    public class BankAccount
//{
//    private readonly string m_customerName;
//    private double m_balance;

//    private BankAccount() { }

//    public BankAccount(string customerName, double balance)
//    {
//        m_customerName = customerName;
//        m_balance = balance;
//    }

//    public string CustomerName
//    {
//        get { return m_customerName; }
//    }

//    public double Balance
//    {
//        get { return m_balance; }
//    }

//    public void Debit(double amount)
//    {
//        if (amount > m_balance)
//        {
//            throw new ArgumentOutOfRangeException("amount");
//        }

//        if (amount < 0)
//        {
//            throw new ArgumentOutOfRangeException("amount");
//        }

//        m_balance += amount; // intentionally incorrect code
//    }

//    public void Credit(double amount)
//    {
//        if (amount < 0)
//        {
//            throw new ArgumentOutOfRangeException("amount");
//        }

//        m_balance += amount;
//    }

//    public static void Main()
//    {
//        BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

//        ba.Credit(5.77);
//        ba.Debit(11.22);
//        Console.WriteLine("Current balance is ${0}", ba.Balance);
//    }
//}
//}

//using System;

//namespace Bank
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//8.10.2022. Of course the Program.cs has to be modified like in tutorial and Bank project must be
//    referenced in the BankTests project so I do that too and also
// I set Bank project as a startup project
