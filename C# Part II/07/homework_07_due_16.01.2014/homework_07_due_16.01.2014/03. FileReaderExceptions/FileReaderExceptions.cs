using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;

class FileReaderExceptions
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Title = "FileReaderExceptions";        
        Console.WindowHeight = 40;
        Console.WindowWidth = 80;

        string path = " ";

        while (path != string.Empty)
        {
            Console.WriteLine("Please enter a file path to read or ENTER for exit: ");
            path = Console.ReadLine();
            string buffer = string.Empty;
            Console.WriteLine();

            try
            {
                buffer = File.ReadAllText(path);

                for (int i = 0; i < buffer.Length; i++)
                {

                    if (i % 3200 == 0)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.Write("Page {0} of {1} Press any key for next page...", i / 3200, buffer.Length / 3200);
                        Console.ReadKey();
                        Console.SetCursorPosition(1, 0);

                    }
                    Console.Write(buffer[i]);
                }
            }
            catch (System.ArgumentException)
            {
                //ENTER for exit
                Console.WriteLine();
                Console.WriteLine("Goobdye!");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine();
                Console.WriteLine("File not found!");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine();
                Console.WriteLine("Cannot access file! Locked by another process.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine();
                Console.Write("Press any key...");
                Console.ReadKey();
                Console.Clear();
                buffer = string.Empty;
            }

        }
    }
}


