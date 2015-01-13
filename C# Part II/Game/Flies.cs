using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderProject
{
    class Flies
    {
        private int row;
        private int col;
        ConsoleColor flyColor;

        public Flies(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.flyColor;
            }
            set
            {
                this.flyColor = value;
            }
        }

        public int PointsFromColor()
        {
            if (this.flyColor == ConsoleColor.Cyan)
            {
                return 5;
            }
            else if (this.flyColor == ConsoleColor.Green)
            {
                return 10;
            }
            else if (this.flyColor == ConsoleColor.Yellow)
            {
                return 15;
            }
            else if (this.flyColor == ConsoleColor.DarkRed)
            {
                return 40;
            }
            else if (this.flyColor == ConsoleColor.DarkBlue)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        public void Move()
        {
            if (this.Col <= 79)
            {
                Console.SetCursorPosition(this.Col, this.Row);
                this.Col++;

                Console.SetCursorPosition(this.Col - 1, this.Row);
                Console.Write(' ');

                this.Draw();
                System.Threading.Thread.Sleep(100);
                Console.ResetColor();

            }
          
        }

        public void Draw()
        {
            Random rand = new Random();
            
            switch (rand.Next(1,6))
            {
                case 1: this.flyColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine('%'); break;
                case 2: this.flyColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine('%'); break;
                case 3: this.flyColor = ConsoleColor.DarkBlue; Console.ForegroundColor = ConsoleColor.DarkBlue; Console.WriteLine('%'); break;
                case 4: this.flyColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine('%'); break;
                case 5: this.flyColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine('%'); break;
                default:
                    break;
            }
        }
    }
}
