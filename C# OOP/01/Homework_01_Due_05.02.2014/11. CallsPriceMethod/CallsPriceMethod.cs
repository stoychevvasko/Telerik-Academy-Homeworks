﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

/*
<11>
 
Add a method that calculates the total price of the 
calls in the call history. Assume the price per minute 
is fixed and is provided as a parameter.
*/

// Added PriceCalls() method on line 177

namespace _11.CallsPriceMethod
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
        private List<Call> callHistory;

        // static iPhone field
        private static GSM iPhone4S;

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
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new System.ArgumentOutOfRangeException("Price cannot be negative!");
                    }

                    this.price = value;
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
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

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        // static iPhone property

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
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
            this.callHistory = new List<Call>();
        }

        public GSM()
            : this(null, null, null, null)
        {
        }

        // static constructor for the iPhone

        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple Inc.", 450M, "Mr. Apple Fanboi");
            iPhone4S.currentBattery = new Battery("Built-in rechargeable battery", BatteryType.Li_Ion, 200F, 8F);
            iPhone4S.currentDisplay = new Display("960-640 px multi-touch display", 16777216);
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(int position)
        {
            try
            {
                this.CallHistory.RemoveAt(position);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory = null;
        }

        public void PrintCallHistory()
        {
            try
            {
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    Console.WriteLine("CALL NUMBER {0} \nDate: {1} \nTime: {2} \nCall number: {3} \nDuration: {4} sec\n\n",
                    i + 1,
                    this.CallHistory[i].DateAndTime.Value.Date.Date.ToString("dd.MM.yyyy"),
                    this.CallHistory[i].DateAndTime.Value.TimeOfDay.ToString().Substring(0, 8),
                    this.CallHistory[i].NumberDialled,
                    this.CallHistory[i].Duration);
                }
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("(EMPTY)");
                Console.WriteLine();
                //Console.WriteLine(e.Message);
            }
        }

        // Method for Problem 11

        public float PriceCalls(float perMinute)
        {
            float result = 0;
            float perSec = perMinute / 60;

            foreach (var call in this.CallHistory)
            {
                result += ((float)call.Duration * perSec);
            }

            return result;
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
                set
                {
                    try
                    {
                        if (value < 0)
                        {
                            throw new System.ArgumentOutOfRangeException("Hours idle cannot be negative!");
                        }

                        this.hoursIdle = value;
                    }
                    catch (System.ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            public float? HoursTalk
            {
                get { return this.hoursTalk; }
                set
                {
                    try
                    {
                        if (value < 0)
                        {
                            throw new System.ArgumentOutOfRangeException("Hours talk cannot be negative!");
                        }

                        this.hoursTalk = value;
                    }
                    catch (System.ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
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
                set
                {
                    try
                    {
                        if (value < 1)
                        {
                            throw new System.ArgumentOutOfRangeException("Number of colors must be a positive integer!");
                        }

                        this.numberOfColors = value;
                    }
                    catch (System.ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
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

        public class Call
        {
            // Call fields

            private DateTime? dateAndTime;
            private string numberDialled;
            private uint? duration;

            // Call properties

            public DateTime? DateAndTime
            {
                get { return this.dateAndTime; }
                set { this.dateAndTime = value; }
            }

            public string NumberDialled
            {
                get { return this.numberDialled; }
                set { this.numberDialled = value; }
            }

            public uint? Duration
            {
                get { return this.duration; }
                set { this.duration = value; }
            }

            // Call constructors

            public Call(DateTime? dateAndTime, string numberDialled, uint? duration)
            {
                this.DateAndTime = dateAndTime;
                this.NumberDialled = numberDialled;
                this.Duration = duration;
            }

            public Call()
                : this(null, null, null)
            {
            }
        }
    }

    // ^ Class definition 

    //   Program starts here

    class CallsPriceMethod
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // used  	0x0409    for en-US culture otherwise the $ wouldn't show
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(0x0409);
            Console.Title = "CallsPriceMethod";
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 40;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Random rand = new Random();

            GSM phone = GSM.IPhone4S;

            for (int i = 0; i < 5; i++)
            {
                uint duration = (uint)rand.Next(600);
                phone.AddCall(new GSM.Call(DateTime.Now, "Phone number " + rand.Next(100000, 999999), duration));
                Thread.Sleep(rand.Next(300));
            }

            phone.PrintCallHistory();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TOTAL: {0:C}", phone.PriceCalls(0.37F));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;            
        }
    }
}
