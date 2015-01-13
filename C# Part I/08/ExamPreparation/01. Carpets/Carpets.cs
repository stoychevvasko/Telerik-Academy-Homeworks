using System;


// this is the Carpets task from Practice "Telerik Academy Exam 1 @ 27 Dec 2012" 

class Carpets
{
    static void Main()
    {
        int N;
        N = int.Parse(Console.ReadLine());
        

        char[,] carpet;
        carpet = new char[N, N];
        
        int step = 0;
        char filler = '.';

        for (int row = 0; row < N / 2; row++)
        {
            for (int col = 0; col < N / 2; col++)
            {

                carpet[row, col] = filler;
                carpet[N - 1 - row, col] = filler;
                carpet[row, N - 1 - col] = filler;
                carpet[N - 1 - row, N - 1 - col] = filler;

                if (col == N / 2 - 1 - step)
                {
                    carpet[row, col] = '/';
                    carpet[N - 1 - row, col] = '\\';
                    carpet[row, N - 1 - col] = '\\';
                    carpet[N - 1 - row, N - 1 - col] = '/';
                    filler = ' ';
                    step++;
                }

                if (carpet[row, col] == ' ')
                {
                    if (carpet[row, col - 1] == ' ')
                    {
                        carpet[row, col] = '/';
                        carpet[N - 1 - row, col] = '\\';
                        carpet[row, N - 1 - col] = '\\';
                        carpet[N - 1 - row, N - 1 - col] = '/';
                    }
                }

            }
            filler = '.';
        }

      
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(carpet[i, j]);
            }
            Console.WriteLine();
        }

    }
}