using System;
using System.Globalization;
using System.Text;
using System.Threading;

/*
<07>
 
Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
*/

// Used a reference to problem 6 and accessed the namespace
// of problem 6 to avoid repeating code

namespace _07.TestGSMClass
{
    public class GSMTest
    {
        // GSMTest fields

        private _06.IPhone4S.GSM[] testGSMArray = new _06.IPhone4S.GSM[2];

        // GSMTest properties

        public _06.IPhone4S.GSM[] TestGSMArray
        {
            get { return this.testGSMArray; }
            set { this.testGSMArray = value; }
        }

        // GSMTest methods for problem 7

        public GSMTest()
        {
            this.testGSMArray[0] = new _06.IPhone4S.GSM("Nokia 3310", "Nokia Corporation", 74.99M, "Mr. Avg Joe");
            this.testGSMArray[0].CurrentBattery = new _06.IPhone4S.GSM.Battery("BMC-3 (NiMH) 900 mAh", _06.IPhone4S.BatteryType.NiMH, 180F, 2.4F);
            this.testGSMArray[0].CurrentDisplay = new _06.IPhone4S.GSM.Display("84x48 px", 1);

            this.testGSMArray[1] = _06.IPhone4S.GSM.IPhone4S;
        }

        public void DisplayInfo()
        {
            foreach (var item in testGSMArray)
            {
                item.Print();
            }
        }

        public void DisplayiPhoneInfo()
        {
            _06.IPhone4S.GSM.IPhone4S.Print();
        }
    }

    class TestGSMClass
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // used  	0x0409    for en-US culture otherwise the $ wouldn't show
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(0x0409);
            Console.Title = "IPhone4S";
            Console.BufferHeight = Console.WindowHeight = 66;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            // Create an array of few instances of the GSM class.

            GSMTest test001 = new GSMTest();

            // Display the information about the GSMs in the array.

            test001.DisplayInfo();

            // Display the information about the static property IPhone4S.

            test001.DisplayiPhoneInfo();
        }
    }
}
