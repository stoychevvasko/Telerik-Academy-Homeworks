using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a 
//sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the 
//first letter of the string with the first of the key, the second – with the second, etc. When the last key 
//character is reached, the next is the first.

namespace _07.EncoderDecoder
{
    class EncoderDecoder
    {
        static string Encode(string message, string cipher)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (i >= message.Length)
                    {
                        break;
                    }
                    char ch = (char)((int)message[i] ^ (int)cipher[j]);
                    result.Append(ch);
                    i++;
                }
                i--;
            }

            return result.ToString();
        }        
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "EncoderDecoder";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your message for coding here: ");
                    string original = Console.ReadLine();
                    Console.WriteLine();

                    if (original.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }
                    
                    Console.WriteLine("Enter your cipher key here: ");
                    string cipher = Console.ReadLine();

                    Console.WriteLine();

                    if (cipher.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    string encrypted = Encode(original, cipher);

                    Console.WriteLine("The encrypted message");
                    Console.WriteLine(encrypted);
                    Console.WriteLine();

                    string decrypted = Encode(encrypted, cipher);

                    Console.WriteLine("The decrypted message:");
                    Console.WriteLine(decrypted);

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
