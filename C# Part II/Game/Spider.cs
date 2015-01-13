using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderProject
{
    class Spider
    {
        private int row;
        private int col;
        private int health = 10;

        public Spider(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
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

        public bool InWeb(int row, int col, Background background)
        {
            try
            {
                if (background[row, col + 1] == '*')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                if (background[row, col] == '*')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void Draw()
        {
            Console.SetCursorPosition(this.col, this.row);
            Console.WriteLine("Ж");
        }
    }
}
