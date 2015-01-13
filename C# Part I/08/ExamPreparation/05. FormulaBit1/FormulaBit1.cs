using System;


// this is the Formula Bit 1 task from Practice "Telerik Academy Exam 1 @ 27 Dec 2012" 

class FormulaBit1
{

    static public byte[,] cell = new byte[8, 8];
    static public byte x = 0, y = 7;

    static public bool waySouth (int i, int j)
    {
        if (i >= 7)
        {
            return false;
        }
        else if (cell [i,j] == 0 && cell[i+1, j] == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static public bool wayNorth(int i, int j)
    {
        if (i <= 0)
        {
            return false;
        }
        else if (cell[i, j] == 0 && cell[i - 1, j] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static public bool wayWest(int i, int j)
    {
        if (j <= 0)
        {
            return false;
        }
        else if (cell[i, j] == 0 && cell[i, j - 1] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static public bool isThereAnyWay(int i, int j)
    {
        if (i == 7 && j == 0)
        {
            return false;
        }
        else if (waySouth(i, j))
        {
            return true;
        }
        else if (wayWest(i, j))
        {
            return true;
        }
        else if (wayNorth(i, j))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void Main()
    {
        byte number;
        
        for (int i = 0; i < 8; i++)
        {
            number = byte.Parse((Console.ReadLine()));
            for (int j = 0; j < 8; j++)
            {
                if (((number >> j) & 1) == 1)
                {
                    cell[i, 7-j] = 1;
                }
                else
                {
                    cell[i, 7-j] = 0;
                }
            }
        }

        
        byte steps = 0, turns = 0;
        byte way = 1;

        while (isThereAnyWay(x, y))
        {
                                    
            switch (way)
            {
                case 1:
                    {
                        if (waySouth(x, y))
                        {
                            x++;
                            steps++;
                            if ((!waySouth(x, y)) && wayWest(x, y))
                            {
                                turns++;
                                way = 2;
                            }
                        }
                    }
                    break;

                case 2: 
                     {
                        if (wayWest(x, y))
                        {
                            y--;
                            steps++;
                            if ((!wayWest(x, y)) && wayNorth(x, y))
                            {
                                turns++;
                                way = 3;
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        if (wayNorth(x, y))
                        {
                            x--;
                            steps++;
                            if ((!wayNorth(x, y)) && wayWest(x, y))
                            {
                                turns++;
                                way = 2;
                            }
                        }
                    }
                    break;
            }
        }



        //-------------------------------------------

        //while (isThereAnyWay(x, y))
        //{

        //if (waySouth(x, y))
        //{
        //    x++;
        //    steps++;

        //    if (way == 2)
        //    {
        //        turns++;
        //        way = 1;
        //    }

        //    continue;
        //}



        //    if (wayWest(x, y))
        //    {
        //        y--;
        //        steps++;

        //        if (way == 1 || way == 3)
        //        {
        //            turns++;
        //            way = 2;
        //        }

        //        continue;
        //    }


        //    if (wayNorth(x, y))
        //    {
        //        x--;
        //        steps++;

        //        if (way == 2)
        //        {
        //            turns++;
        //            way = 3;
        //        }

        //        continue;
        //    }
        //}


        Console.WriteLine("{0} {1}", steps, turns);

    }
}