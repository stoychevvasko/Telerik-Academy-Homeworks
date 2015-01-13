using System;


// this is the Bit Ball problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

class BitBall
{
    
    static public bool TopAttack (int[], int[])
    {

    }
    
    static void Main()
    {
        int[] teamTop = new int[8];

        for (int i = 0; i < 8; i++)
        {
            teamTop[i] = int.Parse(Console.ReadLine());
        }

        int[] teamBottom = new int[8];

        for (int i = 0; i < 8; i++)
        {
            teamBottom[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            teamBottom[i] = (teamBottom[i] ^ teamTop[i]);
            teamTop[i] = (teamBottom[i] ^ teamTop[i]);
        }

       





        



    }
}