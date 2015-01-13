using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch 
//all exceptions and to free any used resources in the finally block.

class FileDownloadExceptions
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;
        Console.Title = "FileDownloadExceptions";
        Console.Clear();

        string path = " ";

        while (path != string.Empty)
        {
            using (WebClient Client = new WebClient())
            {
                try
                {
                    Console.Write("Path of file to download: ");
                    path = Console.ReadLine();
                    string fileName = path.Substring(path.LastIndexOf('/') + 1, path.Length - 1 - path.LastIndexOf('/'));
                    Client.DownloadFile(path, fileName);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(☺) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Download complete. ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(☺) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                catch (System.ArgumentException)
                {
                    //ENTER to exit
                    Console.WriteLine();
                    Console.WriteLine("Goodbye.");

                    Thread.Sleep(500);
                }
                catch (System.Net.WebException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("<!> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Cannot locate file to download!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("<!> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();                    
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Client.Dispose();
                }
            }
        }
    }
}


