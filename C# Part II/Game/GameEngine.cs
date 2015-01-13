using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderProject
{
    class GameEnginet
    {

        public static int CheckForColision(Spider spider, Flies fly, int currentScore = 0)
        {

            if (spider.Row > fly.Row && spider.Col == fly.Col)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2);
                return -1;
            }
            if (spider.Row == fly.Row && spider.Col-1 == fly.Col)
            {
                currentScore = fly.PointsFromColor();
                Console.SetCursorPosition(fly.Col, fly.Row);
                Console.Write(' ');
                fly = null;

                return currentScore;
            }
            else
            {
                return 0;
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
    }
}
