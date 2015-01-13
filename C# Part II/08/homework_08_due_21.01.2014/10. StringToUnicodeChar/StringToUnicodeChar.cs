using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

namespace _10.StringToUnicodeChar
{
    class StringToUnicodeChar
    {
        static public int getCharCode(char character)
        {
            UTF32Encoding encoding = new UTF32Encoding();
            byte[] bytes = encoding.GetBytes(character.ToString().ToCharArray());
            return BitConverter.ToInt32(bytes, 0);
        } 
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "StringToUnicodeChar";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your string:");
                    string str = Console.ReadLine();

                    if (str.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    StringBuilder result = new StringBuilder();

                    for (int i = 0; i < str.Length; i++)
                    {                        
                        int chInt = Char.ConvertToUtf32(str, i);
                        string res = String.Format("\\u{0, 4}", chInt.ToString("X4"));
                        result.Append(res);
                    }

                    string finalResult = result.ToString();

                    Console.WriteLine();
                    Console.WriteLine("This is the resulting string:");
                    Console.WriteLine(finalResult);
                    Console.WriteLine();
                    Console.WriteLine();                    
                }
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {                    
                    throw;
                }
            }
        }
    }
}
