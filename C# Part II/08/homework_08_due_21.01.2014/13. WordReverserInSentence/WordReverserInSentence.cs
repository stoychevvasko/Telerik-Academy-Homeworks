using System;
using System.Threading;
using System.Globalization;
using System.Text;

/* 
  Write a program that reverses the words in given sentence.
  Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
*/

namespace _13.WordReverserInSentence
{
    class WordReverserInSentence
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "WordReverserInSentence";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your sentence: ");
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    // last character

                    char endingPunctuation = input[input.Length - 1];

                    string[] words = input.Split(' ');
                    
                    // word position of commas

                    bool[] commas = new bool[words.Length];

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i][words[i].Length - 1] == ',')
                        {
                            commas[i] = true;
                            //Console.WriteLine("comas[{0}] is {1}", i, commas[i]);
                        }
                    }

                    StringBuilder newSentence = new StringBuilder();
                    
                    for (int ind = 0; ind < words.Length; ind++)
                    {
                        StringBuilder wrd = new StringBuilder(words[ind]);

                        // purging punctuation

                        for (int i = 0; i < wrd.Length; i++)
                        {
                            if (wrd[i] == ',' || wrd[i] == '.' || wrd[i] == '!' || wrd[i] == '?')
                            {                                
                                wrd.Remove(i, 1);
                            }                            
                        }

                        // re-adding commas

                        if (commas[commas.Length - 1 - ind])
                        {
                            wrd.Append(',');
                        }

                        newSentence.Insert(0, wrd.ToString() + ' ');
                    }

                    // punctuation - last character

                    newSentence[newSentence.Length - 1] = endingPunctuation;

                    Console.WriteLine();
                    Console.WriteLine("The sentence with reversed words is:");
                    Console.WriteLine(newSentence.ToString());
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
