// <copyright file="MainApp.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>
// Observer pattern -- Real World example

namespace ObserverExample
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;
    
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    interface IInvestor
    {
        /// <summary>
        /// Updates observers
        /// </summary>
        /// <param name="stock">stock parameter</param>
        void Update(Stock stock);
    }

    /// <summary>
    /// MainApp startup class for Real-World
    /// Observer Design Pattern.
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
            Console.Title = "Observer Design Pattern Example";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);

            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Stock
    {
        /// <summary>
        /// holds character value 
        /// </summary>
        private string symbol;

        /// <summary>
        /// holds price value 
        /// </summary>
        private double price;

        /// <summary>
        /// holds list of investors
        /// </summary>
        private List<IInvestor> investors = new List<IInvestor>();
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="symbol">symbol parameter</param>
        /// <param name="price">price parameter</param>
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        public string Symbol
        {
            get { return this.symbol; }
        }

        /// <summary>
        /// Adds a new investor to the list of investors.
        /// </summary>
        /// <param name="investor">investor parameter</param>
        public void Attach(IInvestor investor)
        {
            this.investors.Add(investor);
        }

        /// <summary>
        /// Removes an investor from the list of investors.
        /// </summary>
        /// <param name="investor">investor parameter</param>
        public void Detach(IInvestor investor)
        {
            this.investors.Remove(investor);
        }

        /// <summary>
        /// Updates all investors with a message.
        /// </summary>
        public void Notify()
        {
            foreach (IInvestor investor in this.investors)
            {
                investor.Update(this);
            }

            Console.WriteLine(string.Empty);
        }        
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IBM"/> class.
        /// </summary>
        /// <param name="symbol">symbol parameter</param>
        /// <param name="price">price parameter</param>
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
    
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class Investor : IInvestor
    {
        /// <summary>
        /// holds the investor name string
        /// </summary>
        private string name;

        /// <summary>
        /// holds current stock
        /// </summary>
        private Stock stock;

        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">investor name parameter</param>
        public Investor(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets or sets the stock
        /// </summary>
        public Stock Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        /// <summary>
        /// Sends a notification about stock price.
        /// </summary>
        /// <param name="stock">stock parameter</param>
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2:C}", this.name, stock.Symbol, stock.Price);
        }        
    }
}