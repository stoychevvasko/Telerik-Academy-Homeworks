using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SpecialValue
{
    class SpecialValue
    {
        static public int Path(int row, int col)
        {
            return 0;
        }

        static long FindCurrentSpecialValue(int[][] nums, int col, bool[][] used)
        {
            long result = 1;
            int currentRow = 0;

            while (true)
            {
                if (used[currentRow][col])
                {
                    return long.MinValue;
                }

                if (nums[currentRow][col] < 0)
                {
                    result -= nums[currentRow][col];
                    return result;
                }

                int nextCol = nums[currentRow][col];
                used[currentRow][col] = true;
                col = nextCol;

                result++;

                currentRow++;

                if (currentRow == nums.GetLength(0))
                {
                    currentRow = 0;
                }
            }

            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] splitters = { ' ', ',' };

            int[][] nums = new int[n][];


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] numbers = input.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

                nums[i] = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    nums[i][j] = int.Parse(numbers[j]);
                }
            }

            bool[][] used = new bool[n][];

            for (int r = 0; r < n; r++)
            {
                used[r] = new bool[nums[r].Length];
            }

            long max = long.MinValue;

            for (int ind = 0; ind < nums[0].Length; ind++)
            {
                long specialValue = FindCurrentSpecialValue(nums, ind, used);

                if (max < specialValue)
                {
                    max = specialValue;
                }
            }

            Console.WriteLine(max);
        }
    }
}
