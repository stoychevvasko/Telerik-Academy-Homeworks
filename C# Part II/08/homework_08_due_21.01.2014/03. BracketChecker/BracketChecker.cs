using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

namespace _03.BracketChecker
{
    class BracketChecker
    {
        static bool isExpressionCorrect(string expression)
        {
            bool result = true;

            StringBuilder strB = new StringBuilder();
            strB.Append(expression);

            for (int i = 0; i < strB.Length; i++)
            {
                if (strB[i].CompareTo('(') != 0 && strB[i].CompareTo(')') != 0 )
                {
                    strB.Replace(strB[i].ToString(), "");
                    i--;
                }
            }

            int openBrackets = 0;
            int closeBrackets = 0;

            for (int i = 0; i < strB.Length; i++)
            {
                if (strB[i].CompareTo('(') == 0)
                {
                    openBrackets++;
                }
                else if (strB[i].CompareTo(')') == 0)
                {
                    closeBrackets++;
                }
            }

            if (strB[0].CompareTo(')') == 0 || strB[strB.Length - 1].CompareTo('(') == 0)
            {
                result = false;
            }
            else if (openBrackets != closeBrackets)
            {
                result = false;
            }

            //Console.WriteLine(strB.ToString());            

            return result;
        }
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "BracketChecker";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.Write("Enter your string here: ");
                    string str = Console.ReadLine();

                    if (str == "")
                    {
                        throw new System.ArgumentNullException();
                    }

                    if (isExpressionCorrect(str))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("<☻> ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("This expression is correct!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("<!> ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("This expression is not correct!");
                    }
                }
                catch (System.ArgumentNullException)
                {
                    break;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            Console.WriteLine();
        }
    }
}
