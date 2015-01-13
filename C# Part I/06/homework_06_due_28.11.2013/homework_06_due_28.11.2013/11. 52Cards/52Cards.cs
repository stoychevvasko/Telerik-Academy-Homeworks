using System;
using System.Threading;
using System.Globalization;
using System.Text;

class _52Cards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "52Cards";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("This application will print all 52 cards from standard decks");
        Console.WriteLine();
        Console.WriteLine();

        for (int suit = 0; suit < 4; suit++)
        {
            for (int cardNum = 0; cardNum  < 13; cardNum ++)
            {
                switch (cardNum)
                {
                    case 0: Console.Write("Ace of "); break;
                    case 1: Console.Write("Two of "); break;
                    case 2: Console.Write("Three of "); break;
                    case 3: Console.Write("Four of "); break;
                    case 4: Console.Write("Five of "); break;
                    case 5: Console.Write("Six of "); break;
                    case 6: Console.Write("Seven of "); break;
                    case 7: Console.Write("Eight of "); break;
                    case 8: Console.Write("Nine of "); break;
                    case 9: Console.Write("Ten of "); break;
                    case 10: Console.Write("Jack of "); break;
                    case 11: Console.Write("Queen of "); break;
                    case 12: Console.Write("King of "); break;
                }
                
                switch (suit)
                {
                    case 0: Console.WriteLine("spades"); break;
                    case 1: Console.WriteLine("hearts"); break;
                    case 2: Console.WriteLine("diamonds"); break;
                    case 3: Console.WriteLine("clubs"); break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}