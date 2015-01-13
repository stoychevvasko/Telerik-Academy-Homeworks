using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11.CallsPriceMethod;
using System.Globalization;
using System.Threading;

/*
<12>
 
Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.
*/

// Added a reference to _11.CallsPriceMethod

namespace _12.GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // used  	0x0409    for en-US culture otherwise the $ wouldn't show
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(0x0409);
            Console.Title = "GSMCallHistoryTest";
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.ForegroundColor = ConsoleColor.White;            
            
            // Create an instance of the GSM class.

            //GSM test001 = new GSM("Nokia 3310", "Nokia Corporation", 74.99M, "Mr. Avg Joe");
            GSM test001 = new GSM("FakeGSM", "Chinese Sweatshop Inc.");
            test001.CurrentBattery = new GSM.Battery("BMC-3 (NiMH) 900 mAh", BatteryType.NiMH, 180F, 2.4F);
            test001.CurrentDisplay = new GSM.Display("84x48 px", 1);

            Random r = new Random();

            // Add few calls

            for (int i = 0; i < 5; i++)
            {
                test001.CallHistory.Add(new GSM.Call(DateTime.Now, "123-456-789", (uint)r.Next(600)));
            }

            // Display the information about the calls.

            test001.PrintCallHistory();

            // Price

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOTAL: {0:C}", test001.PriceCalls(0.37F));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            // Remove the longest call

            uint? maxDuration = 0;
            int maxIndex = 0;

            for (int i = 0; i < test001.CallHistory.Count; i++)
            {
                if (test001.CallHistory[i].Duration > maxDuration)
                {
                    maxDuration = test001.CallHistory[i].Duration;
                    maxIndex = i;
                }
            }

            test001.DeleteCall(maxIndex);
            Console.ReadKey();

            // Price II

            Console.Clear();            
            test001.PrintCallHistory();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOTAL: {0:C}", test001.PriceCalls(0.37F));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            // Clear CallHistory and final Print
            test001.ClearCallHistory();
            Console.Clear();
            test001.PrintCallHistory();
            Console.WriteLine();
        }
    }
}
