using System;
using System.Threading;
using System.Globalization;
using System.Text;

/*
 Write a program that replaces in a HTML document given as string all the tags 
 <a href="…">…</a> with corresponding tags [URL=…]…/URL].   
 */

namespace _15.HTMLTagReplacer
{
    class HTMLTagReplacer
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "HTMLTagReplacer";

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter your HTML document as string: ");
                    string input = Console.ReadLine();

                    if (input.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    StringBuilder doc = new StringBuilder(input);

                    for (int i = 0; i < doc.Length; i++)
                    {
                        // link begins with "<a"

                        if (doc[i] == '<' && i + 1 < doc.Length && doc[i + 1] == 'a')
                        {
                            StringBuilder oldLink = new StringBuilder();

                            // adding the part before the link

                            while (doc[i] != '"')
                            {
                                oldLink.Append(doc[i]);
                                i++;
                            }
                            oldLink.Append(doc[i]);
                            i++;

                            // link itself

                            StringBuilder link = new StringBuilder();

                            while (doc[i] != '"')
                            {
                                oldLink.Append(doc[i]);
                                link.Append(doc[i]);
                                i++;
                            }

                            // closing tag

                            oldLink.Append(doc[i]);
                            i++;
                            oldLink.Append(doc[i]);
                            i++;

                            StringBuilder newLink = new StringBuilder("[URL=" + link + ']');
                            doc.Replace(oldLink.ToString(), newLink.ToString());
                            oldLink.Clear();
                            newLink.Clear();
                        }   
                    }
                    
                    doc.Replace("</a>", "[/URL]");

                    Console.WriteLine();
                    Console.WriteLine();

                    // print result

                    Console.WriteLine("This is the HTML string after replacement:");
                    Console.WriteLine(doc.ToString());
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
