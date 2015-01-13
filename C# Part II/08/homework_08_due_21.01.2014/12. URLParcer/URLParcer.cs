using System;
using System.Threading;
using System.Globalization;
using System.Text;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL 
//http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

namespace _12.URLParcer
{
    class URLParcer
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.Title = "URLParcer";
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your URL here:");
                    string url = Console.ReadLine();

                    if (url.Length == 0)
                    {
                        throw new System.ArgumentNullException();
                    }

                    Console.WriteLine();
                    StringBuilder protocol = new StringBuilder(url.Substring(0, url.IndexOf(':')));
                    Console.WriteLine("protocol - {0}", protocol.ToString());

                    Console.WriteLine();
                    StringBuilder server = new StringBuilder(url.Substring(url.IndexOf(':') + 3, url.IndexOf('/', url.IndexOf(':') + 3) - url.IndexOf(':') - 3));
                    Console.WriteLine("server - {0}", server.ToString());

                    Console.WriteLine();
                    StringBuilder resource = new StringBuilder(url.Substring(url.IndexOf(':') + 3 + server.Length));
                    Console.WriteLine("resource - {0}", resource.ToString());

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
