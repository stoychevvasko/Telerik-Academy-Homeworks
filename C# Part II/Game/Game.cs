using System;
using System.Threading;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace SpiderProject
{
    class Game
    {
        public enum ForegroundColor
        {
            DarkBlue, DarkGreen, DarkRed, DarkMagenta, DarkYellow, Gray,
            DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White, Black
        };

        public enum BackgroundColor
        {
            Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta,
            DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta,
            Yellow, White
        };

        public static Random rand = new Random();

        public static char[] webs = { 
                      '\u2500', '\u2502', '\u2591', '\u250C', '\u2510','\u2514', 
                      '\u2518','\u251C', '\u2524', '\u252C', '\u2534','\u253C',
                      };

        public static void ChangeColors(ForegroundColor frg, BackgroundColor bgr)
        {
            switch (frg)
            {
                case ForegroundColor.DarkBlue: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                case ForegroundColor.DarkGreen: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case ForegroundColor.DarkRed: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case ForegroundColor.DarkMagenta: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case ForegroundColor.DarkYellow: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case ForegroundColor.Gray: Console.ForegroundColor = ConsoleColor.Gray; break;
                case ForegroundColor.DarkGray: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case ForegroundColor.Blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case ForegroundColor.Green: Console.ForegroundColor = ConsoleColor.Green; break;
                case ForegroundColor.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case ForegroundColor.Red: Console.ForegroundColor = ConsoleColor.Red; break;
                case ForegroundColor.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case ForegroundColor.Yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case ForegroundColor.White: Console.ForegroundColor = ConsoleColor.White; break;
                case ForegroundColor.Black: Console.ForegroundColor = ConsoleColor.Black; break;
            }
            switch (bgr)
            {
                case BackgroundColor.Black: Console.BackgroundColor = ConsoleColor.Black; break;
                case BackgroundColor.DarkBlue: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case BackgroundColor.DarkGreen: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                case BackgroundColor.DarkCyan: Console.BackgroundColor = ConsoleColor.DarkCyan; break;
                case BackgroundColor.DarkRed: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case BackgroundColor.DarkMagenta: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case BackgroundColor.DarkYellow: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case BackgroundColor.Gray: Console.BackgroundColor = ConsoleColor.Gray; break;
                case BackgroundColor.DarkGray: Console.BackgroundColor = ConsoleColor.DarkGray; break;
                case BackgroundColor.Blue: Console.BackgroundColor = ConsoleColor.Blue; break;
                case BackgroundColor.Green: Console.BackgroundColor = ConsoleColor.Green; break;
                case BackgroundColor.Cyan: Console.BackgroundColor = ConsoleColor.Cyan; break;
                case BackgroundColor.Red: Console.BackgroundColor = ConsoleColor.Red; break;
                case BackgroundColor.Magenta: Console.BackgroundColor = ConsoleColor.Magenta; break;
                case BackgroundColor.Yellow: Console.BackgroundColor = ConsoleColor.Yellow; break;
                case BackgroundColor.White: Console.BackgroundColor = ConsoleColor.White; break;
            }

        }

        static public void DrawBox(int consoleY, int consoleX, int height, int width, ForegroundColor frg, BackgroundColor bgr,
        char topLeft, char topRight, char bottomLeft, char bottomRight, char horizontal, char vertical)
        {
            ChangeColors(frg, bgr);
            Console.SetCursorPosition(consoleY, consoleX);
            Console.Write(topLeft);
            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(horizontal);
            }
            Console.Write(topRight);
            Console.SetCursorPosition(consoleY, consoleX + height - 1);
            Console.Write(bottomLeft);
            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(horizontal);
            }
            Console.Write(bottomRight);

            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(consoleY, consoleX + i);
                Console.Write(vertical);
                Console.SetCursorPosition(consoleY + width - 1, consoleX + i);
                Console.Write(vertical);
            }
            Console.ResetColor();
            Console.SetCursorPosition(0, 41);
        }

        static public void DrawSingleBox(int consoleY, int consoleX, int height, int width, ForegroundColor frg, BackgroundColor bgr)
        {
            DrawBox(consoleY, consoleX, height, width, frg, bgr, '\u250C', '\u2510', '\u2514', '\u2518', '\u2500', '\u2502');
        }

        static public void DrawDoubleBox(int consoleY, int consoleX, int height, int width, ForegroundColor frg, BackgroundColor bgr)
        {
            DrawBox(consoleY, consoleX, height, width, frg, bgr, '\u2554', '\u2557', '\u255A', '\u255D', '\u2550', '\u2551');
        }

        static public void IntroFlash(ForegroundColor frg, BackgroundColor bgr, int wait, string studioName)
        {
            Console.SetCursorPosition(0, 0);
            ChangeColors(frg, bgr);
            Console.Clear();
            Console.SetCursorPosition(18, 18);
            Console.WriteLine(studioName);
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(wait);
        }

        static void PlayVid(string path)
        {
            StreamReader read = new StreamReader(@path);
            int numberOfFrames = 114;
            int currentFrame = 1;
            while (currentFrame <= numberOfFrames)
            {
                string frame = read.ReadLine();
                Console.SetCursorPosition(0, 1);
                int buffer = 1;
                char bufferChar = frame[0];

                for (int i = 1; i < frame.Length; i++)
                {
                    buffer = 1;
                    bufferChar = frame[i - 1];

                    while (frame[i - 1].CompareTo(frame[i]) == 0)
                    {
                        if (i < frame.Length - 1)
                        {
                            buffer++;
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    if (bufferChar == ' ')
                    {
                        StringBuilder printBuffer = new StringBuilder();
                        for (int j = 0; j < buffer; j++)
                        {
                            printBuffer.Append(webs[rand.Next(webs.Length)]);                            
                        }
                        ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                        Console.Write(printBuffer.ToString());
                        printBuffer = null;
                    }
                    else if (bufferChar == '0')
                    {
                        StringBuilder printBuffer = new StringBuilder();
                        for (int j = 0; j < buffer; j++)
                        {
                            printBuffer.Append(' ');
                        }
                        ChangeColors(ForegroundColor.Black, BackgroundColor.Black);
                        Console.Write(printBuffer);
                        printBuffer = null;
                    }
                    else if (bufferChar == '1')
                    {
                        StringBuilder printBuffer = new StringBuilder();
                        for (int j = 0; j < buffer; j++)
                        {
                            printBuffer.Append(webs[rand.Next(webs.Length)]); 
                        }
                        ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                        Console.Write(printBuffer);
                        printBuffer = null;
                    }

                }
                Console.SetCursorPosition(0, 41);
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                Console.SetCursorPosition(35, 33);
                Console.Write(" LOADING... ");
                Console.SetCursorPosition(0, 0);
                DrawDoubleBox(0, 35, 4, 80, ForegroundColor.Red, BackgroundColor.Black);
                ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                for (int ind = 0; ind <= (double)((double)currentFrame / (double)numberOfFrames) * 77; ind++)
                {
                    if (ind % 2 == 0)
                    {
                        ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                        Console.SetCursorPosition(1 + ind, 36);
                        Console.Write('\u2584');
                        ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                        Console.SetCursorPosition(1 + ind, 37);
                        Console.Write('\u2580');
                    }
                    else
                    {
                        ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                        Console.SetCursorPosition(1 + ind, 36);
                        Console.Write('\u2584');
                        ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                        Console.SetCursorPosition(1 + ind, 37);
                        Console.Write('\u2580');
                    }

                    Console.SetCursorPosition(0, 41);
                }
                currentFrame++;
                //Thread.Sleep(rand.Next(13));
            }
            read.Close();

            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Thread.Sleep(500);

            Console.Clear();
        }

        static public void Intro()
        {
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.Clear();
            string studioName = "S C A R L E T     E N T E R T A I N M E N T";
            Console.SetCursorPosition(18, 18);
            for (int i = 0; i < studioName.Length; i++)
            {
                Console.Write(studioName[i]);
                Thread.Sleep(rand.Next(22, 55));
            }
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(1200);
            IntroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(99), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Black, rand.Next(99), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(99), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Black, rand.Next(33), studioName);
            IntroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(50, 150), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Black, rand.Next(33), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(99), studioName);
            IntroFlash(ForegroundColor.White, BackgroundColor.Black, rand.Next(99), studioName);
            IntroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(99), studioName);
            Console.SetCursorPosition(0, 41);
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.Clear();
            Thread.Sleep(444);
            PlayVid(@"..\..\video.txt");
            Thread.Sleep(444);
            Console.Clear();
            Thread.Sleep(333);
        }

        static public void OutroFlash(ForegroundColor frg, BackgroundColor bgr, int wait, string goodbyeWeb)
        {
            Console.SetCursorPosition(0, 0);
            ChangeColors(frg, bgr);
            Console.Clear();
            Console.Write(goodbyeWeb);
            Thread.Sleep(wait);
        }

        static public void Outro()
        {
            Console.SetCursorPosition(0, 0);
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.Clear();
            string goodbye = "s w e e t  d r e a m s,  l i t t l e  f l i e s... ";
            Console.SetCursorPosition(14, 17);
            for (int i = 0; i < goodbye.Length; i++)
            {
                Console.Write(goodbye[i]);
                Thread.Sleep(rand.Next(33));
            }
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(1200);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            StreamReader reader = new StreamReader(@"../../outro.txt");
            string goodbyeWeb = reader.ReadToEnd();
            reader.Close();
            Console.Write(goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.DarkRed, BackgroundColor.White, rand.Next(33), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(50, 150), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(33), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.Black, BackgroundColor.White, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(44, 99), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.DarkRed, BackgroundColor.White, rand.Next(33), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(50, 150), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(33), goodbyeWeb);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.Black, BackgroundColor.White, rand.Next(44), goodbyeWeb);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(44), goodbyeWeb);
            Console.SetCursorPosition(0, 41);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
        }

        static public void DrawMainMenu()
        {
            StreamReader reader = new StreamReader(@"../../main_menu.txt");
            string mainMenuString = reader.ReadToEnd().ToString();
            reader.Close();
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(0, 0);

            int buffer = 1;
            char bufferChar = mainMenuString[0];
            int i = 1;
            while (i < mainMenuString.Length)
            {
                buffer = 1;
                bufferChar = mainMenuString[i - 1];
                while (mainMenuString[i - 1].CompareTo(mainMenuString[i]) == 0)
                {
                    if (i < mainMenuString.Length - 1)
                    {
                        buffer++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bufferChar == '.')
                {                    
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);                        
                    }
                    ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                else if (bufferChar == '*')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);    
                    }
                    ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                else if (bufferChar == '=')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);    
                    }
                    ChangeColors(ForegroundColor.DarkGray, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                i++;
            }
            Console.SetCursorPosition(0, 41);
        }

        static public void DrawMainMenuChoice(int choice)
        {
            for (int i = 1; i <= 4; i++)
            {
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                if (i == choice)
                {
                    continue;
                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            {
                                Console.SetCursorPosition(52, 3);
                                Console.Write("       P L A Y       ");
                                DrawSingleBox(51, 2, 3, 23, ForegroundColor.Red, BackgroundColor.Black);
                            }
                            break;
                        case 2:
                            {
                                Console.SetCursorPosition(52, 7);
                                Console.Write("   T U T O R I A L   ");
                                DrawSingleBox(51, 6, 3, 23, ForegroundColor.Red, BackgroundColor.Black);
                            }
                            break;
                        case 3:
                            {
                                Console.SetCursorPosition(7, 32);
                                Console.Write("   H I G H   S C O R E   ");
                                DrawSingleBox(6, 31, 3, 27, ForegroundColor.Red, BackgroundColor.Black);
                            }
                            break;
                        case 4:
                            {
                                Console.SetCursorPosition(7, 36);
                                Console.Write("         Q U I T         ");
                                DrawSingleBox(6, 35, 3, 27, ForegroundColor.Red, BackgroundColor.Black);
                            }
                            break;
                    }
                }
            }
            switch (choice)
            {
                case 1:
                    {
                        DrawDoubleBox(51, 2, 3, 23, ForegroundColor.White, BackgroundColor.Black);
                        Console.SetCursorPosition(51, 3);
                        Console.Write('\u25Ba' + "       P L A Y       " + '\u25C4');
                    }
                    break;
                case 2:
                    {
                        DrawDoubleBox(51, 6, 3, 23, ForegroundColor.White, BackgroundColor.Black);
                        Console.SetCursorPosition(51, 7);
                        Console.Write('\u25Ba' + "   T U T O R I A L   " + '\u25C4');
                    }
                    break;
                case 3:
                    {
                        DrawDoubleBox(6, 31, 3, 27, ForegroundColor.White, BackgroundColor.Black);
                        Console.SetCursorPosition(6, 32);
                        Console.Write('\u25Ba' + "   H I G H   S C O R E   " + '\u25C4');
                    }
                    break;
                case 4:
                    {
                        DrawDoubleBox(6, 35, 3, 27, ForegroundColor.White, BackgroundColor.Black);
                        Console.SetCursorPosition(6, 36);
                        Console.Write('\u25Ba' + "         Q U I T         " + '\u25C4');
                    }
                    break;
            }
            Console.SetCursorPosition(22, 20);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("   S C A R L E T     S P I D E R   ");
            DrawDoubleBox(21, 18, 5, 37, ForegroundColor.Red, BackgroundColor.Black);
            DrawSingleBox(22, 19, 3, 35, ForegroundColor.Black, BackgroundColor.Black);
            Console.SetCursorPosition(0, 41);
        }

        static public int CycleMainMenu(ref int choice, ref bool choiceMade)
        {
            DrawMainMenuChoice(choice);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        choice--;
                        break;
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        choice++;
                        break;
                    }
                    else if (pressedKey.Key == ConsoleKey.Escape)
                    {
                        choice = 4;
                        choiceMade = true;
                        break;
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        choiceMade = true;
                        break;
                    }
                }
            }
            if (choice > 4)
            {
                choice = 1;
            }
            else if (choice < 1)
            {
                choice = 4;
            }
            return choice;
        }

        static public void SelectionAnimation(int choice)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(55, 99));
                if (i % 2 == 0)
                {
                    DrawMainMenu();
                }
                switch (choice)
                {
                    case 1:
                        {

                            Console.SetCursorPosition(52, 3);
                            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                            Console.Write("       P L A Y       ");
                            DrawDoubleBox(51, 2, 3, 23, ForegroundColor.Red, BackgroundColor.Black);
                            Console.SetCursorPosition(0, 41);
                            Thread.Sleep(rand.Next(44, 99));
                            Console.SetCursorPosition(52, 3);
                            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                            Console.Write("       P L A Y       ");
                            DrawDoubleBox(51, 2, 3, 23, ForegroundColor.White, BackgroundColor.Black);
                        }
                        break;
                    case 2:
                        {
                            Console.SetCursorPosition(52, 7);
                            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                            Console.Write("   T U T O R I A L   ");
                            DrawSingleBox(51, 6, 3, 23, ForegroundColor.Red, BackgroundColor.Black);
                            Console.SetCursorPosition(0, 41);
                            Thread.Sleep(rand.Next(44, 99));
                            Console.SetCursorPosition(52, 7);
                            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                            Console.Write("   T U T O R I A L   ");
                            DrawDoubleBox(51, 6, 3, 23, ForegroundColor.White, BackgroundColor.Black);
                        }
                        break;
                    case 3:
                        {
                            Console.SetCursorPosition(7, 32);
                            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                            Console.Write("   H I G H   S C O R E   ");
                            DrawSingleBox(6, 31, 3, 27, ForegroundColor.Red, BackgroundColor.Black);
                            Console.SetCursorPosition(0, 41);
                            Thread.Sleep(rand.Next(44, 99));
                            Console.SetCursorPosition(7, 32);
                            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                            Console.Write("   H I G H   S C O R E   ");
                            DrawDoubleBox(6, 31, 3, 27, ForegroundColor.White, BackgroundColor.Black);
                        }
                        break;
                    case 4:
                        {
                            Console.SetCursorPosition(7, 36);
                            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                            Console.Write("         Q U I T         ");
                            DrawSingleBox(6, 35, 3, 27, ForegroundColor.Red, BackgroundColor.Black);
                            Console.SetCursorPosition(0, 41);
                            Thread.Sleep(rand.Next(44, 99));
                            Console.SetCursorPosition(7, 36);
                            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                            Console.Write("         Q U I T         ");
                            DrawDoubleBox(6, 35, 3, 27, ForegroundColor.White, BackgroundColor.Black);
                        }
                        break;
                }
            }
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(rand.Next(500));
        }

        static public int MainMenu()
        {
            DrawMainMenu();
            int choice = 1;
            bool choiceMade = false;
            while (true)
            {
                choice = CycleMainMenu(ref choice, ref choiceMade);
                if (!choiceMade)
                {
                    continue;
                }
                else
                {
                    SelectionAnimation(choice);
                    return choice;
                }
            }
        }

        public static void DrawHighScoreEntry(int place, string name, int points)
        {
            try
            {
                int pos = 2 + (place % 9) * 4;

                DrawDoubleBox(4, pos, 3, 7, ForegroundColor.Red, BackgroundColor.Black);
                DrawDoubleBox(13, pos, 3, 38, ForegroundColor.Red, BackgroundColor.Black);
                DrawDoubleBox(53, pos, 3, 23, ForegroundColor.Red, BackgroundColor.Black);

                Console.SetCursorPosition(5, pos + 1);
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write("  {0}  ", place);

                Console.SetCursorPosition(14, pos + 1);
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write(' ' + name + new string(' ', 35 - name.Length));

                Console.SetCursorPosition(54, pos + 1);
                string pointsStr = points.ToString();
                while (pointsStr.Length < 9)
                {
                    pointsStr = "0" + pointsStr;
                }
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write("   {0}{1}{2} {3}{4}{5} {6}{7}{8} pts   ",
                    pointsStr[0], pointsStr[1], pointsStr[2], pointsStr[3], pointsStr[4], pointsStr[5],
                    pointsStr[6], pointsStr[7], pointsStr[8]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.SetCursorPosition(1, 38);
                ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                Console.Write("<!> ERROR <!>  ");
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                Console.Write("Cannot fit more than {0} entries on screen.", place);
                Thread.Sleep(rand.Next(44, 66));

                Console.SetCursorPosition(1, 38);
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                Console.Write("<!> ERROR <!>  ");
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write("Cannot fit {0} entries on screen.", place);
                Thread.Sleep(rand.Next(44, 66));
            }
        }

        public static void DrawHighScoreMenu()
        {
            StreamReader reader = new StreamReader(@"../../high_score_menu.txt");
            string HighScoreString = reader.ReadToEnd().ToString();
            reader.Close();
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(0, 0);

            int buffer = 1;
            char bufferChar = HighScoreString[0];
            int i = 1;
            while (i < HighScoreString.Length)
            {
                buffer = 1;
                bufferChar = HighScoreString[i - 1];
                while (HighScoreString[i - 1].CompareTo(HighScoreString[i]) == 0)
                {
                    if (i < HighScoreString.Length - 1)
                    {
                        buffer++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bufferChar == '.')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);                        
                    }
                    ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                else if (bufferChar == '*')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);           
                    }
                    ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                i++;
            }
            //DrawDoubleBox(0, 0, 41, 80, ForegroundColor.DarkRed, BackgroundColor.Black);
            Console.SetCursorPosition(27, 2);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("   H I G H   S C O R E   ");
            DrawDoubleBox(26, 1, 3, 27, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(25, 0, 5, 29, ForegroundColor.Red, BackgroundColor.Black);
            DrawHighScoreEntry(1, "Tanya", 360);
            DrawHighScoreEntry(2, "You are The Best", 340);
            DrawHighScoreEntry(3, "I like flies", 220);
            DrawHighScoreEntry(4, "Excited", 215);
            DrawHighScoreEntry(5, "Lets play again", 180);
            DrawHighScoreEntry(6, "I am hungry", 165);
            DrawHighScoreEntry(7, "Little hungry spider", 135);
            DrawHighScoreEntry(8, "test", 130);

            DrawSingleBox(2, 37, 3, 13, ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(3, 38);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("  B A C K  ");
            Console.SetCursorPosition(0, 41);

            Console.ReadKey();

            for (int endi = 0; endi < 6; endi++)
            {
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(55, 99));
                if (endi % 2 == 0)
                {
                    buffer = 1;
                    i = 1;
                    Console.SetCursorPosition(0, 0);
                    while (i < HighScoreString.Length)
                    {
                        buffer = 1;
                        bufferChar = HighScoreString[i - 1];
                        while (HighScoreString[i - 1].CompareTo(HighScoreString[i]) == 0)
                        {
                            if (i < HighScoreString.Length - 1)
                            {
                                buffer++;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (bufferChar == '.')
                        {                            
                            StringBuilder bufferWeb = new StringBuilder();
                            for (int j = 0; j < buffer; j++)
                            {                                
                                bufferWeb.Append(webs[rand.Next(webs.Length)]);
                            }
                            ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                            Console.Write(bufferWeb.ToString());
                            bufferWeb = null;
                        }
                        else if (bufferChar == '*')
                        {
                            StringBuilder bufferWeb = new StringBuilder();
                            for (int j = 0; j < buffer; j++)
                            {
                                bufferWeb.Append(webs[rand.Next(webs.Length)]);
                            }
                            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                            Console.Write(bufferWeb.ToString());
                            bufferWeb = null;
                        }
                        i++;
                    }

                }
                //DrawDoubleBox(0, 0, 41, 80, ForegroundColor.DarkRed, BackgroundColor.Black);
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(44, 99));
                Console.SetCursorPosition(3, 38);
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                Console.Write("  B A C K  ");
                DrawSingleBox(2, 37, 3, 13, ForegroundColor.Red, BackgroundColor.Black);
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(44, 99));
                DrawDoubleBox(2, 37, 3, 13, ForegroundColor.White, BackgroundColor.Black);
                Console.SetCursorPosition(3, 38);
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write("  B A C K  ");
                Console.SetCursorPosition(0, 41);
            }
            Console.SetCursorPosition(0, 41);
            Console.Write(new string(' ', 16));
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(rand.Next(500));
        }

        static public void DrawTutorial()
        {
            string path = @"../../tutorial.txt";

            StreamReader reader = new StreamReader(@path);
            string vidStream = reader.ReadToEnd().ToString();
            reader.Close();
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(0, 0);
            char bufferChar = vidStream[0];
            int buffer = 1;
            int i = 1;
            while (i < vidStream.Length)
            {
                buffer = 1;
                bufferChar = vidStream[i - 1];
                while (vidStream[i - 1].CompareTo(vidStream[i]) == 0)
                {
                    if (i < vidStream.Length - 1)
                    {
                        buffer++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bufferChar == '.')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);
                    }
                    ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                else if (bufferChar == '*')
                {
                    StringBuilder bufferWeb = new StringBuilder();
                    for (int j = 0; j < buffer; j++)
                    {
                        bufferWeb.Append(webs[rand.Next(webs.Length)]);
                    }
                    ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                    Console.Write(bufferWeb.ToString());
                    bufferWeb = null;
                }
                i++;
            }
            DrawSingleBox(2, 37, 3, 13, ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(3, 38);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("  B A C K  ");
            Console.SetCursorPosition(0, 41);

            Console.SetCursorPosition(27, 2);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("     T U T O R I A L     ");
            DrawDoubleBox(26, 1, 3, 27, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(25, 0, 5, 29, ForegroundColor.Red, BackgroundColor.Black);

            DrawSingleBox(6, 11, 3, 13, ForegroundColor.Black, BackgroundColor.Black);
            DrawSingleBox(5, 9, 7, 15, ForegroundColor.Black, BackgroundColor.Black);
            DrawSingleBox(4, 8, 9, 17, ForegroundColor.Black, BackgroundColor.Black);
            DrawSingleBox(3, 7, 11, 19, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(2, 6, 13, 21, ForegroundColor.Red, BackgroundColor.Black);
            Console.SetCursorPosition(4, 8);
            ChangeColors(ForegroundColor.Cyan, BackgroundColor.Black);
            Console.WriteLine(" %  =   5 points");
            Console.SetCursorPosition(4, 10);
            ChangeColors(ForegroundColor.Green, BackgroundColor.Black);
            Console.WriteLine(" %  =  10 points");
            Console.SetCursorPosition(4, 12);
            ChangeColors(ForegroundColor.Yellow, BackgroundColor.Black);
            Console.WriteLine(" %  =  15 points");
            Console.SetCursorPosition(4, 14);
            ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
            Console.WriteLine(" %  =  40 points");
            Console.SetCursorPosition(4, 16);
            ChangeColors(ForegroundColor.DarkBlue, BackgroundColor.Black);
            Console.WriteLine(" %  =  50 points");


            DrawDoubleBox(31, 12, 1, 41, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(30, 11, 3, 43, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(29, 10, 5, 45, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(28, 9, 7, 47, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(27, 8, 9, 49, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(26, 7, 11, 51, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(25, 6, 13, 53, ForegroundColor.Red, BackgroundColor.Black);

            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.SetCursorPosition(27, 8);
            Console.Write("Use the [\u25B2] or [\u25BC] arrow keys at any time to move");
            Console.SetCursorPosition(27, 9);
            Console.Write("up or down.");

            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.SetCursorPosition(27, 12);
            Console.Write("Use the [\u25C4] or [\u25BA] arrow keys                 ");
            Console.SetCursorPosition(27, 13);
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            Console.Write("          only on the horizontal web             ");
            Console.SetCursorPosition(27, 14);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.Write("                           to move left or right.");
            Console.SetCursorPosition(27, 15);
            Console.Write("                                                 ");
            Console.SetCursorPosition(27, 16);
            Console.Write("Eat flies for points.                            ");

            DrawSingleBox(16, 37, 3, 62, ForegroundColor.Red, BackgroundColor.Black);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            Console.SetCursorPosition(17, 38);
            Console.Write("            Press [Esc] to go back to Main Menu             ");



            TutorialDemo();
            // ends tutorial

            Console.SetCursorPosition(4, 21);
            string[,] tutorialPic = new string[14, 72]; // two dimentional array used
            int offsetRow = 21;
            int offsetCol = 4;
            for (int row = 0; row < 14; row++)
            {
                for (int col = 0; col < 72; col++)
                {
                    if (row < 2)
                    {
                        tutorialPic[row, col] = "*";
                    }
                    else
                    {
                        tutorialPic[row, col] = " ";
                    }
                }
            }

            tutorialPic[2, 40] = "|";
            tutorialPic[3, 40] = "|";
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            tutorialPic[4, 40] = "Ж";
            Console.SetCursorPosition(40 + offsetCol, 4 + offsetRow);
            Console.Write(tutorialPic[4, 40]);

            ChangeColors(ForegroundColor.Green, BackgroundColor.Black);
            tutorialPic[5, 24] = "%";
            Console.SetCursorPosition(24 + offsetCol, 5 + offsetRow);
            Console.Write(tutorialPic[5, 24]);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            tutorialPic[5, 26] = "-";
            Console.SetCursorPosition(26 + offsetCol, 5 + offsetRow);
            Console.Write(tutorialPic[5, 26]);
            tutorialPic[5, 27] = ">";
            Console.SetCursorPosition(27 + offsetCol, 5 + offsetRow);
            Console.Write(tutorialPic[5, 27]);


            ChangeColors(ForegroundColor.Cyan, BackgroundColor.Black);
            tutorialPic[7, 30] = "%";
            Console.SetCursorPosition(30 + offsetCol, 7 + offsetRow);
            Console.Write(tutorialPic[7, 30]);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
            tutorialPic[7, 32] = "-";
            Console.SetCursorPosition(32 + offsetCol, 7 + offsetRow);
            Console.Write(tutorialPic[7, 32]);
            tutorialPic[7, 33] = ">";
            Console.SetCursorPosition(33 + offsetCol, 7 + offsetRow);
            Console.Write(tutorialPic[7, 33]);

            tutorialPic[7, 30] = "%";
            tutorialPic[7, 32] = "-";
            tutorialPic[7, 33] = ">";

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 72; col++)
                {
                    if (row < 4)
                    {
                        ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                    }
                    else
                    {
                        ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                    }
                    Console.SetCursorPosition(col + offsetCol, row + offsetRow);
                    Console.Write(tutorialPic[row, col]);
                }
            }

            Console.SetCursorPosition(0, 41);

            

            Console.ReadKey();

            // goes back to Main Menu

            for (int endi = 0; endi < 6; endi++)
            {
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(55, 99));
                if (endi % 2 == 0)
                {
                    buffer = 1;
                    i = 1;
                    Console.SetCursorPosition(0, 0);
                    while (i < vidStream.Length)
                    {
                        buffer = 1;
                        bufferChar = vidStream[i - 1];
                        while (vidStream[i - 1].CompareTo(vidStream[i]) == 0)
                        {
                            if (i < vidStream.Length - 1)
                            {
                                buffer++;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (bufferChar == '.')
                        {
                            
                            StringBuilder bufferWeb = new StringBuilder();
                            for (int j = 0; j < buffer; j++)
                            {
                                bufferWeb.Append(webs[rand.Next(webs.Length)]);                                
                            }
                            ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                            Console.Write(bufferWeb.ToString());
                            bufferWeb = null;
                        }
                        else if (bufferChar == '*')
                        {
                            buffer = 1;
                            i = 1;
                            Console.SetCursorPosition(0, 0);
                            while (i < vidStream.Length)
                            {
                                buffer = 1;
                                bufferChar = vidStream[i - 1];
                                while (vidStream[i - 1].CompareTo(vidStream[i]) == 0)
                                {
                                    if (i < vidStream.Length - 1)
                                    {
                                        buffer++;
                                        i++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (bufferChar == '.')
                                {
                                    StringBuilder bufferWeb = new StringBuilder();
                                    for (int j = 0; j < buffer; j++)
                                    {                                        
                                        bufferWeb.Append(webs[rand.Next(webs.Length)]);
                                    }
                                    ChangeColors(ForegroundColor.DarkRed, BackgroundColor.Black);
                                    Console.Write(bufferWeb.ToString());
                                    bufferWeb = null;
                                }
                                else if (bufferChar == '*')
                                {
                                    StringBuilder bufferWeb = new StringBuilder();
                                    for (int j = 0; j < buffer; j++)
                                    {
                                        bufferWeb.Append(webs[rand.Next(webs.Length)]);
                                    }
                                    ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                                    Console.Write(bufferWeb.ToString());
                                    bufferWeb = null;
                                }
                                i++;
                            }
                        }
                        i++;
                    }

                }
                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(44, 99));
                Console.SetCursorPosition(3, 38);
                ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
                Console.Write("  B A C K  ");
                DrawSingleBox(2, 37, 3, 13, ForegroundColor.Red, BackgroundColor.Black);

                Console.SetCursorPosition(0, 41);
                Thread.Sleep(rand.Next(44, 99));
                Console.SetCursorPosition(3, 38);
                ChangeColors(ForegroundColor.White, BackgroundColor.Black);
                Console.Write("  B A C K  ");
                DrawDoubleBox(2, 37, 3, 13, ForegroundColor.White, BackgroundColor.Black);
                Console.SetCursorPosition(0, 41);
            }
            Console.Write(new string(' ', 16));
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(rand.Next(500));
        }

        static public void TutorialDemo()
        {
            DrawDoubleBox(3, 21, 14, 74, ForegroundColor.Black, BackgroundColor.Black);
            DrawDoubleBox(2, 20, 16, 76, ForegroundColor.Red, BackgroundColor.Black);


            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(4, 24 + i);
                Console.Write(new string(' ', 72));
            }

            Console.SetCursorPosition(4, 22);
            ChangeColors(ForegroundColor.Red, BackgroundColor.Black);
            for (int miniInd = 0; miniInd < 72; miniInd++)
            {
                Console.Write('*');
            }
            Console.SetCursorPosition(4, 23);
            for (int miniInd = 0; miniInd < 72; miniInd++)
            {
                Console.Write('*');
            }

            Console.SetCursorPosition(0, 41);
        }

        static void highScore()
        {
            ChangeColors(ForegroundColor.Green, BackgroundColor.Red);
            Console.SetCursorPosition(0, 0);
            ChangeColors(ForegroundColor.Black, BackgroundColor.DarkRed);
            Console.Clear();
            Random rand = new Random();
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(1200);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            StreamReader reader = new StreamReader(@"..\..\NewHighScore.txt");
            string highScore = reader.ReadToEnd();
            reader.Close();
            OutroFlash(ForegroundColor.Yellow, BackgroundColor.DarkBlue, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Blue, BackgroundColor.Black, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Yellow, BackgroundColor.Yellow, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Blue, BackgroundColor.Black, rand.Next(50, 150), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Red, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(44), highScore);
            OutroFlash(ForegroundColor.Yellow, BackgroundColor.DarkBlue, rand.Next(44), highScore);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(44, 99), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkBlue, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.Blue, BackgroundColor.Black, rand.Next(33), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(50, 150), highScore);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(33), highScore);
            OutroFlash(ForegroundColor.Yellow, BackgroundColor.Red, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(150), highScore);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(150), highScore);
            Console.SetCursorPosition(0, 41);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
        }

        static void gameOver()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.BufferHeight = Console.WindowHeight = 42;
            Console.BufferWidth = Console.WindowWidth = 80;
            ChangeColors(ForegroundColor.Green, BackgroundColor.Red);
            Console.SetCursorPosition(0, 0);
            ChangeColors(ForegroundColor.Black, BackgroundColor.DarkRed);
            Console.Clear();
            Random rand = new Random();
            Console.SetCursorPosition(0, 41);
            Thread.Sleep(1200);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            StreamReader reader = new StreamReader(@"..\..\GameOverSpider2.txt");
            string over = reader.ReadToEnd();
            reader.Close();
            StreamReader readerSpider = new StreamReader(@"..\..\GameOver.txt");
            string overSpider = readerSpider.ReadToEnd();
            reader.Close();
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(150), over);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(150), over);
            OutroFlash(ForegroundColor.DarkRed, BackgroundColor.White, rand.Next(150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(50, 150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.Black, rand.Next(44), over);
            OutroFlash(ForegroundColor.Black, BackgroundColor.White, rand.Next(44), over);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(44, 99), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(150), over);
            OutroFlash(ForegroundColor.White, BackgroundColor.Red, rand.Next(150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(150), over);
            OutroFlash(ForegroundColor.DarkRed, BackgroundColor.White, rand.Next(33), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.White, rand.Next(50, 150), over);
            OutroFlash(ForegroundColor.Red, BackgroundColor.DarkRed, rand.Next(33), over);
            OutroFlash(ForegroundColor.Black, BackgroundColor.Black, rand.Next(150), overSpider);
            OutroFlash(ForegroundColor.White, BackgroundColor.White, rand.Next(150), overSpider);
            OutroFlash(ForegroundColor.DarkGray, BackgroundColor.Black, rand.Next(150), overSpider);
            Console.SetCursorPosition(0, 41);
            ChangeColors(ForegroundColor.White, BackgroundColor.Black);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.BufferHeight = Console.WindowHeight = 42;
            Console.BufferWidth = 80;
            Console.WindowWidth = 80;
            Console.Title = "Scarlet Spider";

            Intro();
           // highScore();

            int menuOutcome = MainMenu();

            while (menuOutcome != 4)
            {
                Console.Clear();

                if (menuOutcome == 1)
                {
                    // START GAME 
                    #region
                    Console.SetCursorPosition(0, 0);
                    Background background = new Background(40, 80); // create a new background

                    for (int row = 0; row < 2; row++)
                    {
                        for (int col = 0; col < background.ColsLength; col++)
                        {
                            background[row, col] = '*'; // fill the first two rows with web -> *
                        }
                    }

                    background.Draw();

                    Spider spider = new Spider(1, 40); // start position at start of game (in the middle of the first row)
                    spider.Draw();

                    Flies fly = new Flies(20, 0);

                    List<Flies> fliesInGame = new List<Flies>();
                    fliesInGame.Add(new Flies(5, 0));
                    fliesInGame.Add(new Flies(10, 0));
                    fliesInGame.Add(new Flies(15, 0));
                    fliesInGame.Add(new Flies(20, 0));

                    int points = 0;

                    Stopwatch timer = new Stopwatch();
                    timer.Start();
                    bool[] usedFlies = new bool[4];
                    int currentFly = rand.Next(0, 4);
                    int consoleClearCount = 2;
                    int whileCount = 0;
                    while (true)
                        {
                        consoleClearCount++;
                        Console.SetCursorPosition(79, consoleClearCount);
                            Console.Write(' ');
                        if (consoleClearCount == 40)
                        {
                            consoleClearCount = 2;
                        }
                        whileCount++;
                        if (whileCount == 10)
                        {
                            currentFly = rand.Next(0, 4);
                            usedFlies[currentFly] = true;
                            whileCount = 0;
                        }


                        if (usedFlies[0] == true)
                        {
                            fliesInGame[0].Move();
                            points += GameEnginet.CheckForColision(spider, fliesInGame[0], points);
                            if (GameEnginet.CheckForColision(spider, fliesInGame[0], points) > 0)
                            {
                                fliesInGame[0] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(0, new Flies(rand.Next(3, 40), 0));
                                fliesInGame[0].Move();
                        }
                            if (fliesInGame[0].Col == 79)
                            {
                                fliesInGame[0] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(0, new Flies(rand.Next(3, 40), 0));
                            }
                            if (GameEnginet.CheckForColision(spider, fliesInGame[0], points) == -1)
                            {
                                break;
                            }

                        }
                        if (usedFlies[1] == true)
                        {
                            fliesInGame[1].Move();
                            points += GameEnginet.CheckForColision(spider, fliesInGame[1], points);
                            if (GameEnginet.CheckForColision(spider, fliesInGame[1], points) > 0)
                            {
                                fliesInGame[1] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(1, new Flies(rand.Next(3, 40), 0));
                                fliesInGame[1].Move();
                            }
                            if (fliesInGame[1].Col == 79)
                            {
                                fliesInGame[1] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(1, new Flies(rand.Next(3, 40), 0));
                            }
                            if (GameEnginet.CheckForColision(spider, fliesInGame[1], points) == -1)
                            {
                                break;
                            }
                        }
                        if (usedFlies[2] == true)
                        {
                            fliesInGame[2].Move();
                            points += GameEnginet.CheckForColision(spider, fliesInGame[2], points);
                            if (GameEnginet.CheckForColision(spider, fliesInGame[2], points) > 0)
                            {
                                fliesInGame[2] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(2, new Flies(rand.Next(3, 40), 0));
                                fliesInGame[2].Move();
                            }
                            if (fliesInGame[2].Col == 79)
                            {
                                fliesInGame[2] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(2, new Flies(rand.Next(3, 40), 0));
                            }
                            if (GameEnginet.CheckForColision(spider, fliesInGame[2], points) == -1)
                            {
                                break; // break;
                            }
                        }
                        if (usedFlies[3] == true)
                        {
                            fliesInGame[3].Move();
                            points += GameEnginet.CheckForColision(spider, fliesInGame[3], points);
                            if (GameEnginet.CheckForColision(spider, fliesInGame[3], points) > 0)
                            {
                                fliesInGame[3] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(3, new Flies(rand.Next(3, 40), 0));
                                fliesInGame[3].Move();
                            }
                            if (fliesInGame[3].Col == 79)
                            {
                                fliesInGame[3] = null;
                                fliesInGame.Remove(null);
                                fliesInGame.Insert(3, new Flies(rand.Next(3, 40), 0));
                            }
                            if (GameEnginet.CheckForColision(spider, fliesInGame[3], points) == -1)
                            {
                                break;
                            }
                        }

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                            while (Console.KeyAvailable)
                            {
                                Console.ReadKey(true);
                            }
                            if (spider.InWeb(spider.Row, spider.Col, background))
                            {
                                if (pressedKey.Key == ConsoleKey.LeftArrow) // move left if possible
                                {
                                    if (spider.Col > 0)
                                    {
                                        spider.Col--;
                                        spider.Draw();
                                        Console.SetCursorPosition(spider.Col + 1, spider.Row);
                                        Console.Write('*');
                                    }
                                }
                                if (pressedKey.Key == ConsoleKey.RightArrow) // move right if possible
                                {
                                    if (spider.Col + 1 < Console.WindowWidth)
                                    {
                                        spider.Col++;
                                        spider.Draw();
                                        Console.SetCursorPosition(spider.Col - 1, spider.Row);
                                        Console.Write('*');
                                    }
                                }
                            }

                            if (pressedKey.Key == ConsoleKey.DownArrow) // move down if possible
                            {
                                if (spider.Row + 1 < 40)
                                {
                                    spider.Row++;
                                    spider.Draw();
                                    Console.SetCursorPosition(spider.Col, spider.Row - 1);
                                    if (!spider.InWeb(spider.Row - 1, spider.Col, background))
                                    {
                                        Console.Write('|');
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(spider.Col, spider.Row - 1);
                                        Console.Write('*');
                                    }
                                }
                            }
                            if (pressedKey.Key == ConsoleKey.UpArrow) // move up if possible
                            {
                                if (spider.Row > 0)
                                {
                                    spider.Row--;
                                    spider.Draw();
                                    Console.SetCursorPosition(spider.Col, spider.Row + 1);

                                    if (!spider.InWeb(spider.Row + 1, spider.Col, background))
                                    {
                                        Console.Write(' ');
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(spider.Col, spider.Row + 1);
                                        Console.Write('*');
                                    }
                                }
                            }
                        }
                        Console.SetCursorPosition(60, 41);
                        Console.Write("Score: " + points);
                    }
                    #endregion
                    Console.SetCursorPosition(0, 0);
                    gameOver();
                    
                }
                else if (menuOutcome == 2)
                {
                    DrawTutorial();
                }

                if (menuOutcome == 3)
                {
                    DrawHighScoreMenu();
                }

                menuOutcome = MainMenu();
            }

            Outro();
        }
    }
}