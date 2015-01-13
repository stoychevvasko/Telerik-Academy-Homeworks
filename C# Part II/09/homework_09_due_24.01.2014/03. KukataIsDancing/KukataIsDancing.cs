using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.KukataIsDancing
{
    class KukataIsDancing
    {
        static public string[,] board = 
        {
            { "RED", "BLUE", "RED"},
            { "BLUE", "GREEN", "BLUE"},
            { "RED", "BLUE", "RED"},
        };

        static public int TurnLeft(int direction)
        {
            // if looking up

            if (direction == 0)
            {
                return 3;
            }
            else if (direction == 1) // if looking right
            {
                return 0;
            }
            else if (direction == 2) // if looking down
            {
                return 1;
            }
            else // if (direction == 3) // if looking left
            {
                return 2;
            }
        }

        static public int TurnRight(int direction)
        {
            if (direction == 0)
            {
                return 1;
            }
            else if (direction == 1) // if looking right
            {
                return 2;
            }
            else if (direction == 2) // if looking down
            {
                return 3;
            }
            else // if (direction == 3) // if looking left
            {
                return 0;
            }
        }

        static public void CalculateNewSpot(int direction, int currentSpotX, int currentSpotY, ref int nextSpotX, ref int nextSpotY)
        {
            if (direction == 0) // if looking up
            {
                if (currentSpotX != 0)
                {
                    nextSpotX = currentSpotX - 1;
                }
                else
                {
                    nextSpotX = 2;
                }

                nextSpotY = currentSpotY;
            }
            else if (direction == 1) // if looking right
            {
                if (currentSpotY != 2)
                {
                    nextSpotY = currentSpotY + 1;
                }
                else
                {
                    nextSpotY = 0;
                }

                nextSpotX = currentSpotX;
            }
            else if (direction == 2) // if looking down
            {
                if (currentSpotX != 2)
                {
                    nextSpotX = currentSpotX + 1;
                }
                else
                {
                    nextSpotX = 0;
                }

                nextSpotY = currentSpotY;
            }
            else // if (direction == 3) // if looking left
            {
                if (currentSpotY != 0)
                {
                    nextSpotY = currentSpotY - 1;
                }
                else
                {
                    nextSpotY = 2;
                }

                nextSpotX = currentSpotX;
            }
        }

        static public void Walk(ref int direction, ref int currentSpotX, ref int currentSpotY, ref int nextSpotX, ref int nextSpotY)
        {
            CalculateNewSpot(direction, currentSpotX, currentSpotY, ref nextSpotX, ref nextSpotY);
            
            currentSpotX = nextSpotX;
            currentSpotY = nextSpotY;            
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> commands = new List<string>();

            for (int i = 0; i < n; i++)
            {
                commands.Add(Console.ReadLine());
            }

            foreach (string item in commands)
            {
                int currentSpotX = 1;
                int currentSpotY = 1;

                int nextSpotX = 0;
                int nextSpotY = 1;

                int direction = 0; // 0 - up, 1 - right, 2 - down, 3 - left


                for (int ind = 0; ind < item.Length; ind++)
                {
                    switch (item[ind])
                    {
                        case 'W': Walk(ref direction, ref currentSpotX, ref currentSpotY, ref nextSpotX, ref nextSpotY); break;
                        case 'L': direction = TurnLeft(direction); break;
                        case 'R': direction = TurnRight(direction); break;
                    }
                }

                Console.WriteLine(board[currentSpotX, currentSpotY]);
            }
        }
    }
}
