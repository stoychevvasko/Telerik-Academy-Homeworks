// <copyright file="MainApp.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>
// Builder pattern -- Real World example

namespace BuilderExample
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// MainApp startup class for Real-World
    /// Builder Design Pattern.
    /// </summary>
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.SetWindowSize(83, 41);
            Console.Title = "Builder Design Pattern Example";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Shop
    {
        /// <summary>
        /// Builder uses a complex series of steps
        /// </summary>
        /// <param name="vehicleBuilder">VehicleBuilder parameter</param>
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        /// <summary>
        /// contains Vehicle object
        /// </summary>
        protected Vehicle vehicle;

        /// <summary>
        /// Gets vehicle information.
        /// </summary>
        public Vehicle Vehicle
        {
            get { return this.vehicle; }
        }

        // Abstract build methods
        public abstract void BuildFrame();

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();
    }

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class MotorCycleBuilder : VehicleBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MotorCycleBuilder"/> class.
        /// </summary>
        public MotorCycleBuilder()
        {
            this.vehicle = new Vehicle("MotorCycle");
        }
        
        /// <summary>
        /// Builds frames.
        /// </summary>
        public override void BuildFrame()
        {
            this.vehicle["frame"] = "MotorCycle Frame";
        }

        /// <summary>
        /// Builds engines.
        /// </summary>
        public override void BuildEngine()
        {
            this.vehicle["engine"] = "500 cc";
        }

        /// <summary>
        /// Builds wheels.
        /// </summary>
        public override void BuildWheels()
        {
            this.vehicle["wheels"] = "2";
        }

        /// <summary>
        /// Builds doors.
        /// </summary>
        public override void BuildDoors()
        {
            this.vehicle["doors"] = "0";
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarBuilder"/> class.
        /// </summary>
        public CarBuilder()
        {
            this.vehicle = new Vehicle("Car");
        }
        
        /// <summary>
        /// Builds frames.
        /// </summary>
        public override void BuildFrame()
        {
            this.vehicle["frame"] = "Car Frame";
        }

        /// <summary>
        /// Builds engines.
        /// </summary>
        public override void BuildEngine()
        {
            this.vehicle["engine"] = "2500 cc";
        }
        
        /// <summary>
        /// Builds wheels.
        /// </summary>
        public override void BuildWheels()
        {
            this.vehicle["wheels"] = "4";
        }
        
        /// <summary>
        /// Builds doors.
        /// </summary>
        public override void BuildDoors()
        {
            this.vehicle["doors"] = "4";
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>
    class ScooterBuilder : VehicleBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScooterBuilder"/> class.
        /// </summary>
        public ScooterBuilder()
        {
            this.vehicle = new Vehicle("Scooter");
        }
        
        /// <summary>
        /// Builds frames.
        /// </summary>
        public override void BuildFrame()
        {
            this.vehicle["frame"] = "Scooter Frame";
        }
        
        /// <summary>
        /// Builds engines
        /// </summary>
        public override void BuildEngine()
        {
            this.vehicle["engine"] = "50 cc";
        }

        /// <summary>
        /// Builds wheels
        /// </summary>
        public override void BuildWheels()
        {
            this.vehicle["wheels"] = "2";
        }
        
        /// <summary>
        /// Builds doors.
        /// </summary>
        public override void BuildDoors()
        {
            this.vehicle["doors"] = "0";
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// stores vehicle type information in string format
        /// </summary>
        private string vehicleType;

        /// <summary>
        /// stores parts in a Dictionary data structure
        /// </summary>
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="vehicleType">vehicleType string parameter</param>
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }
                
        /// <summary>
        /// Indexer for access
        /// </summary>
        /// <param name="key">key parameter</param>
        /// <returns>information stored</returns>
        public string this[string key]
        {
            get { return this.parts[key]; }
            set { this.parts[key] = value; }
        }
        
        /// <summary>
        /// Display information.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", this.vehicleType);
            Console.WriteLine(" Frame : {0}", this.parts["frame"]);
            Console.WriteLine(" Engine : {0}", this.parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", this.parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", this.parts["doors"]);
        }
    }
}