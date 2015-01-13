using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a method that adds two positive integer 
//     numbers represented as arrays of digits (each array 
//     element arr[i] contains a digit; the last digit is 
//     kept in arr[0]). Each of the numbers that will be 
//     added could have up to 10 000 digits.

public class BigIntAddition
{
    class MyBigInt
    {
        private int[] arr;

        //getter

        public int Length
        {
            get { return this.arr.Length; }            
        }

        //indexer

        public int this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        //default constructor

        public MyBigInt()
        {
            this.arr = new int[1];
            this.arr[0] = 0;
        }

        //constructor with string parameter

        public MyBigInt(string feed)
        {
            this.arr = new int[feed.Length];

            int count = 0;

            for (int i = feed.Length - 1; i >= 0; i--)
            {
                this.arr[count] = int.Parse(feed[i].ToString());
                count++;
            }
        }

        //constructor with int parameter

        public MyBigInt(int feed)
        {
            string stringFeed = feed.ToString();

            this.arr = new int[stringFeed.Length];

            int count = 0;

            for (int i = stringFeed.Length - 1; i >= 0; i--)
            {
                this.arr[count] = int.Parse(stringFeed[i].ToString());
                count++;
            }
        }

        //ToString operator overloaded

        public override string ToString()
        {
            string result = "";

            for (int i = this.Length - 1; i >= 0; i--)
            {
                result += this[i];
            }

            return result;
        }

        // operator + overloaded

        public static MyBigInt operator +(MyBigInt numberOne, MyBigInt numberTwo)
        {
            string result = "";

            List<int> resultList = new List<int>();
            int extra = 0;

            if (numberOne.Length >= numberTwo.Length)
            {
                for (int i = 0; i < numberOne.Length; i++)
                {
                    if (i <= numberTwo.Length - 1)
                    {
                        resultList.Add((numberOne[i] + numberTwo[i] + extra) % 10);
                        extra = (numberOne[i] + numberTwo[i] + extra) / 10;
                    }
                    else
                    {
                        resultList.Add((numberOne[i] + extra) % 10);
                        extra = (numberOne[i] + extra) / 10;
                    }
                }

                while (extra != 0)
                {
                    resultList.Add(extra % 10);
                    extra /= 10;
                }
            }
            else
            {
                for (int i = 0; i < numberTwo.Length; i++)
                {
                    if (i <= numberOne.Length - 1)
                    {
                        resultList.Add((numberOne[i] + numberTwo[i] + extra) % 10);
                        extra = (numberOne[i] + numberTwo[i] + extra) / 10;
                    }
                    else
                    {
                        resultList.Add((numberTwo[i] + extra) % 10);
                        extra = (numberTwo[i] + extra) / 10;
                    }
                }

                while (extra != 0)
                {
                    resultList.Add(extra % 10);
                    extra /= 10;
                }
            }

            foreach (int item in resultList)
            {
                result = item + result;
            }

            return new MyBigInt(result);
        }
    }

    // end of class definition, program starts here
    
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BigIntAddition";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        
        Console.Write("Enter the first positive integer here:  ");
        string keyboardInput = Console.ReadLine();
        MyBigInt firstTestNumber = new MyBigInt(keyboardInput);

        Console.WriteLine();
        Console.Write("Enter the second positive integer here: ");
        keyboardInput = Console.ReadLine();
        MyBigInt secondTestNumber = new MyBigInt(keyboardInput);
        
        MyBigInt resultingTestNumber = firstTestNumber + secondTestNumber;
        Console.WriteLine();
        Console.WriteLine("The resulting sum is {0}.", resultingTestNumber.ToString());
        
        Console.ReadKey();
    }
}
