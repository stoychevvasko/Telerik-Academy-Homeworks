using System;
using System.Globalization;
using System.Text;
using System.Threading;

/*
<01>
 
Define a class that holds information about a mobile phone device: 
model, manufacturer, price, owner, 
battery characteristics (model, hours idle and hours talk) and 
display characteristics (size and number of colors). 
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
*/

namespace _01.MobilePhoneDevice
{
    public class GSM
    {
        // GSM fields

        private string model;
        private string manufacturer;
        private decimal price;
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

        public decimal Price
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

        public class Battery
        {
            // Battery fields

            private string model;
            private float hoursIdle;
            private float hoursTalk;

            // Battery properties

            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }

            public float HoursIdle
            {
                get { return this.hoursIdle; }
                set { this.hoursIdle = value; }
            }

            public float HoursTalk
            {
                get { return this.hoursTalk; }
                set { this.hoursTalk = value; }
            }
        }

        public class Display
        {
            // Display fields

            private string size;
            private uint numberOfColors;

            // Display properties

            public string Size
            {
                get { return this.size; }
                set { this.size = value; }
            }

            public uint NumberOfColors
            {
                get { return this.numberOfColors; }
                set { this.numberOfColors = value; }
            }
        }
    }        

    class MobilePhoneDevice
    {
        static void Main()
        {
                    
        }
    }
}
