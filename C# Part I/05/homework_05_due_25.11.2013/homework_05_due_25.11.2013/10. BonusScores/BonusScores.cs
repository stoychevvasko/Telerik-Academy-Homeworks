using System;
using System.Threading;
using System.Globalization;
using System.Text;

class BonusScores
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BonusScores.exe";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();


        Console.WriteLine("This application will apply bonus scores to the scores");
        Console.WriteLine("");
        Console.WriteLine("within the 1-9 range as provided by the user.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter the original score from 1 to 9: ");

        string keyboardInput = Console.ReadLine();
        int originalScore;
        
        while (!int.TryParse(keyboardInput, out originalScore))
        {
            Console.WriteLine();
            Console.WriteLine("Cannot be converted to numeric value! Try again!");
            Console.WriteLine();
            Console.Write("Please enter the original score from 1 to 9: ");
            keyboardInput = Console.ReadLine();
        }

        int finalScore;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        switch (originalScore)
        {
            case 1: 
            case 2:
            case 3: finalScore = originalScore * 10; Console.WriteLine("Your final score is {0} =)", finalScore); break;
            case 4: 
            case 5:
            case 6: finalScore = originalScore * 100; Console.WriteLine("Your final score is {0} =)", finalScore); break;
            case 7: 
            case 8:
            case 9: finalScore = originalScore * 1000; Console.WriteLine("Your final score is {0} =)", finalScore); break;
            case 0:
            default: Console.WriteLine("Error! Invalid score! Sorry, I don't know what to do with this... =("); break;
        }           

          // default here covers any numeric values outside of the required range, 
          // such as when the user decides to enter a double-digit score

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}