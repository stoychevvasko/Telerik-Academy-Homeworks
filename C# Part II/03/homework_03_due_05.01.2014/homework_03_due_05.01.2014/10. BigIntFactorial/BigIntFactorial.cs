using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Collections.Generic;

//     Write a program to calculate n! for each n in the 
//     range [1..100]. Hint: Implement first a method 
//     that multiplies a number represented as array of 
//     digits by given integer number. 

public class BigIntFactorial
{
    // I am expanding upon MyBigInt class that I implemented in problem 8, the methods I've collapsed are
    // copied from there so do skip on down to the new methods

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

        //problem 10
        //this method multiples a MyBigInt by an int

        public static MyBigInt MultiplyByInt(MyBigInt number, int factor)
        {
            string result = "";

            List<int> resultList = new List<int>();
            int extra = 0;

            for (int i = 0; i < number.Length; i++)
            {
                resultList.Add((number[i] * factor + extra) % 10);
                extra = (number[i] * factor + extra) / 10;
            }

            while (extra != 0)
            {
                resultList.Add(extra % 10);
                extra /= 10;
            }
           
            foreach (int item in resultList)
            {
                result = item + result;
            }

            return new MyBigInt(result);
        }

        //this method adds final zeros, it effectively multiples a MyBigInt by powers of 10

        public static MyBigInt AddFinalZero(MyBigInt number, int numberOfZeros)
        {
            string numberAsString = number.ToString();
            
            for (int i = 0; i < numberOfZeros; i++)
            {
                numberAsString = numberAsString + "0";
            }            
            
            return new MyBigInt(numberAsString);
        }
        
        // operator * overloaded - not necessary but did it just for fun

        public static MyBigInt operator *(MyBigInt number, MyBigInt factor)
        {
            MyBigInt temp = new MyBigInt();
            MyBigInt result = new MyBigInt(0);

            for (int factorDigit = 0; factorDigit < factor.Length; factorDigit++)
            {
                temp = MyBigInt.MultiplyByInt(number, factor[factorDigit]);
                temp = MyBigInt.AddFinalZero(temp, factorDigit);
                result = result + temp;
            }           

            return result;
        }

        // Factorial method

        public static MyBigInt Factorial(int factorialBase)
        {
            if (factorialBase == 1)
            {
                return new MyBigInt(1);
            }
            else
            {
                return (MultiplyByInt(Factorial(factorialBase - 1), factorialBase));
            }
        }
    }

    // end of class definition, program starts here

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "BigIntFactorial";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        for (int num = 1; num < 101; num++)
        {
            Console.WriteLine("{0,3}! = {1}", num, MyBigInt.Factorial(num));
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
