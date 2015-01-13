using System;
using System.Threading;
using System.Globalization;
using System.Text;

//     Write a program that finds the maximal increasing 
//     sequence in an array. Example: 
//     {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.

class MaxSeqOfIncreasingElements
{
    //     this is a recursive method that returns the number of consecutive
    //     equal elements from an array starting from a given position called index

    static public int NumberOfElementsInSequence(int[] array, int index, int arrayLength)
    {
        if (index + 1 >= arrayLength)
        {
            return 1;

            //   array exhausted, last element - sequence of 1 element
        }
        else if (array[index] != (array[index + 1] - 1))
        {
            return 1;

            //     next element is not part of increasing sequence - sequence of 1 element
        }
        else
        {
            return (1 + NumberOfElementsInSequence(array, index + 1, arrayLength));

            //     next element is equal to current element + 1 therefore 1 is added to the next 
            //     recursive instance; the addition ultimately results in the total number
            //     of increasing elements in a sequence
        }
    }

    //     program starts here

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.SetWindowSize(83, 41);
        Console.Title = "MaxSeqOfIncreasingElements";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine("  Write a program that finds the maximal increasing ");
        Console.WriteLine("  sequence in an array. Example: ");
        Console.WriteLine("  {3, 2, 3, 4, 2, 2, 4} --> {2, 3, 4}.");
        Console.WriteLine();
        Console.WriteLine();

        int arrayLength = 0;
        Console.Write("  What is the length of the array? ");
        string keyboardInput = Console.ReadLine();

        while (!int.TryParse(keyboardInput, out arrayLength) || (arrayLength == 0))
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Invalid array length, please try again!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  What is the length of the array? ");
            keyboardInput = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("  array[{0}] = ", i);
            keyboardInput = Console.ReadLine();


            while (!int.TryParse(keyboardInput, out array[i]))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Cannot be converted to a valid numeric value, please try again!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  array[{0}] = ", i);
                keyboardInput = Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        int[] sequenceLengths = new int[arrayLength];

        //     ^ this array will contain the length of sequences of increasing elements from the original array
        //     e.g. if the original array is, say, {1, 2, 3, 5, 8} then sequenceLengths would be {3, 2, 1, 1, 1} - 
        //     the zeroth element is part of a 3-element sequence, the first element is part of a two-element
        //     sequence, the second element is part of a single-element sequence, etc., the last element is 
        //     followed by none and is thus always a part of a single-element sequence by definition

        for (int i = 0; i < arrayLength; i++)
        {
            sequenceLengths[i] = NumberOfElementsInSequence(array, i, arrayLength);
        }

        //     ^ now we've filled in the sequenceLengths array as described

        int maxSequenceIndex = 0;

        //     ^ this variable will store the index of the longest sequence of equal elements from the 
        //     original array and below we've found it

        for (int i = 0; i < arrayLength; i++)
        {
            if (sequenceLengths[i] >= sequenceLengths[maxSequenceIndex])
            {
                maxSequenceIndex = i;
            }
        }

        //     this code for testing purposes only, you can un-comment it if you like, or just skip it


        //for (int i = 0; i < arrayLength; i++)
        //{
        //    Console.WriteLine("  sequenceLengths[{0}] = {1}", i, sequenceLengths[i]);
        //}

        //Console.WriteLine();
        //Console.WriteLine("  maxSequenceIndex = {0}", maxSequenceIndex);
        //Console.WriteLine();


        //     finally, we will now print via console the actual longest sequence

        Console.WriteLine("  Here is the longest sequence of increasing elements within the original array:");
        Console.WriteLine();

        for (int i = maxSequenceIndex; i < maxSequenceIndex + sequenceLengths[maxSequenceIndex]; i++)
        {
            Console.WriteLine("  array[{0}] = {1}", i, array[i]);
        }

        //     and we're done, thanks for your patience! =)

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
    }
}