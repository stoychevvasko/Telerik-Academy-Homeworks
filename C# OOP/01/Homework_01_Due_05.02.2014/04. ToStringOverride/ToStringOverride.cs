using System;
using System.Globalization;
using System.Text;
using System.Threading;

/*
<04>
 
Add a method in the GSM class for displaying all 
information about it. Try to override ToString().
*/

// already created Print methods
// Added ToString() override on line 117

namespace _04.ToStringOverride
{
    public enum BatteryType
    {
        NiCd, Lead_acid, NiMH, NiZn, AgZn, Li_Ion
    }

    public class GSM
    {
        // GSM fields

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery currentBattery;
        private Display currentDisplay;

        // GSM properties

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery CurrentBattery
        {
            get { return this.currentBattery; }
            set { this.currentBattery = value; }
        }

        public Display CurrentDisplay
        {
            get { return this.currentDisplay; }
            set { this.currentDisplay = value; }
        }

        // GSM constructors

        public GSM(string model, string manufacturer,
        decimal? price = null, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.currentBattery = new Battery();
            this.currentDisplay = new Display();
        }

        public GSM()
            : this(null, null, null, null)
        {
        }

        // GSM Print method

        public void Print()
        {
            string breakLine = new string('-', 39);
            Console.WriteLine(breakLine);
            Console.WriteLine("\t{0} GSM device", this.Model);
            Console.WriteLine(breakLine);
            Console.WriteLine();
            Console.WriteLine("Model: {0, 32}", this.Model);
            Console.WriteLine("Manufacturer: {0, 25}", this.Manufacturer);
            Console.WriteLine("Price: {0, 32:C}", this.Price);
            Console.WriteLine("Owner: {0, 32}", this.Owner);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Battery");
            Console.WriteLine();
            //Battery BatteryInstance = new Battery();
            this.CurrentBattery.Print();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display");
            Console.WriteLine();
            //Display DisplayInstance = new Display();
            this.CurrentDisplay.Print();
            Console.ForegroundColor = ConsoleColor.White;
        }

        // ToString override

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(new string('-', 39));
            result.Append(String.Format("\n\t{0} GSM device\n", this.Model));
            result.Append(new string('-', 39));
            result.Append(String.Format("\n\nModel: {0, 32}", this.Model));
            result.Append(String.Format("\nManufacturer: {0, 25}", this.Manufacturer));
            result.Append(String.Format("\nPrice: {0, 32:C}", this.Price));
            result.Append(String.Format("\nOwner: {0, 32}\n\nBattery\n\n", this.Owner));
            result.Append(String.Format("Model: {0, 32}\n", this.CurrentBattery.Model));
            result.Append(String.Format("Battery type: {0, 25}\n", this.CurrentBattery.BatteryType));
            result.Append(String.Format("Hours Idle: {0, 27}\n", this.CurrentBattery.HoursIdle));
            result.Append(String.Format("Hours Talk: {0, 27}\n\n", this.CurrentBattery.HoursTalk));
            result.Append(String.Format("Display\n\nSize: {0, 33}\n", this.currentDisplay.Size));
            result.Append(String.Format("Number of colors: {0, 21}\n", this.CurrentDisplay.NumberOfColors));

            return result.ToString();
        }

        public class Battery
        {
            // Battery fields

            private string model;
            private BatteryType? batteryType;
            private float? hoursIdle;
            private float? hoursTalk;

            // Battery properties

            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }

            public float? HoursIdle
            {
                get { return this.hoursIdle; }
                set { this.hoursIdle = value; }
            }

            public float? HoursTalk
            {
                get { return this.hoursTalk; }
                set { this.hoursTalk = value; }
            }

            public BatteryType? BatteryType
            {
                get { return this.batteryType; }
                set { this.batteryType = value; }
            }

            // Battery constructors

            public Battery(string model, BatteryType? batteryType, float? hoursIdle, float? hoursTalk)
            {
                this.Model = model;
                this.BatteryType = batteryType;
                this.HoursIdle = hoursIdle;
                this.HoursTalk = hoursTalk;
            }

            public Battery()
                : this(null, null, null, null)
            {
            }

            // Battery Print

            public void Print()
            {
                Console.WriteLine("Model: {0, 32}", this.Model);
                Console.WriteLine("Battery type: {0, 25}", this.BatteryType);
                Console.WriteLine("Hours Idle: {0, 27}", this.HoursIdle);
                Console.WriteLine("Hours Talk: {0, 27}", this.HoursTalk);
                Console.WriteLine();
            }
        }

        public class Display
        {
            // Display fields

            private string size;
            private uint? numberOfColors;

            // Display properties

            public string Size
            {
                get { return this.size; }
                set { this.size = value; }
            }

            public uint? NumberOfColors
            {
                get { return this.numberOfColors; }
                set { this.numberOfColors = value; }
            }

            // Display constructor

            public Display(string size, uint? numberOfColors)
            {
                this.Size = size;
                this.NumberOfColors = numberOfColors;
            }

            public Display()
                : this(null, null)
            {
            }

            // Display Print

            public void Print()
            {
                Console.WriteLine("Size: {0, 33}", this.Size);
                Console.WriteLine("Number of colors: {0, 21}", this.NumberOfColors);
                Console.WriteLine();
            }

        }
    }

    // ^ Class definition 

    //   Program starts here

    class ToStringOverride
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // used  	0x0409    for en-US culture otherwise the $ wouldn't show
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(0x0409);
            Console.Title = "ToStringOverride";
            Console.BufferHeight = Console.WindowHeight = 44;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            GSM exampleDefaultGSM = new GSM();
            
            //exampleDefaultGSM.Print();
            Console.WriteLine(exampleDefaultGSM.ToString());


            GSM nokia3310 = new GSM("Nokia 3310", "Nokia Corporation", 74.99M, "Mr. Avg Joe");
            nokia3310.CurrentBattery = new GSM.Battery("BMC-3 (NiMH) 900 mAh", BatteryType.NiMH, 180F, 2.4F);
            nokia3310.CurrentDisplay = new GSM.Display("84x48 px", 1);

            //nokia3310.Print();
            Console.WriteLine(nokia3310.ToString());
        }
    }
}
