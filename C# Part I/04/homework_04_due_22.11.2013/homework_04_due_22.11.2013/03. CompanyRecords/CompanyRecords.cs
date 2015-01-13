using System;
using System.Threading;
using System.Globalization;
using System.Text;

class CompanyRecords
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CompanyRecords.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("__________________________________________________");
        Console.WriteLine();
        Console.WriteLine("   Welcome to FakeCompany Inc. records entry.");
        Console.WriteLine();
        Console.WriteLine("__________________________________________________");
        Console.WriteLine();

        Console.WriteLine("Please enter your company name:");
        string companyName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Please enter your company address:");
        string companyAddress = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Please enter your company phone number:");
        string companyPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Please enter your company fax number:");
        string companyFax = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Please enter your company website:");
        string companyWebsite = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Please enter the name of your company manager:");
        string companyManager = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("__________________________________________________");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Processing");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("________________________________________________________");
        Console.WriteLine();
        Console.WriteLine("   COMPANY RECORD FOR {0}", companyName);
        Console.WriteLine();
        Console.WriteLine("________________________________________________________");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Company name:                     {0, 22}", companyName);
        Console.WriteLine();
        Console.WriteLine("Company address:                  {0, 22}", companyAddress);
        Console.WriteLine();
        Console.WriteLine("Company phone number:             {0, 22}", companyPhone);
        Console.WriteLine();
        Console.WriteLine("Company fax number:               {0, 22}", companyFax);
        Console.WriteLine();
        Console.WriteLine("Company website:                  {0, 22}", companyWebsite);
        Console.WriteLine();
        Console.WriteLine("Company manager:                  {0, 22}", companyManager);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}