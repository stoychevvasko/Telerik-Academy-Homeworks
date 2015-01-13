using System;
using System.Threading;
using System.Globalization;
using System.Text;

class CopyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "CopyrightTriangle";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("Use Lucida Console for your console font so that symbols are displayed properly.");
        Console.WriteLine();
        Console.WriteLine("To change your console font, right-click on the console title bar and select ");
        Console.WriteLine("Properties --> Font --> Lucida Console --> OK.");
        Console.WriteLine();
        Console.WriteLine();

        string s = "\u00A9";

        string triangle = "   " + s + "\n  " + s + " " + s + "  \n " + s + "   " + s + "\n" + s + " " + s + " " + s + " " + s + "\n\n\n";
        Console.WriteLine(triangle);

        string reverseTriangle = s + " " + s + " " + s + " " + s + "\n " + s + "   " + s + "\n  " + s + " " + s + "  \n   " + s + "\n\n\n";
        Console.WriteLine(reverseTriangle);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}