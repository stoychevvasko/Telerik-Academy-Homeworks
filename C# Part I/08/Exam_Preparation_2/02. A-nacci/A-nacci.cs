//using System;


//// this is the A-nacci problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

//class Anacci
//{


//    static void Main()
//    {
//        string input = Console.ReadLine();
//        char first = input[0];

//        input = Console.ReadLine();
//        char second = input[0];

//        int L = int.Parse(Console.ReadLine());
//        int lengthOfArray;


//        if (L == 1)
//        {
//            Console.WriteLine(first);
//        }
//        else if (L == 2)
//        {
//            char third = (char)(first + second - 65);
//            while (third > 90)
//            {
//                third = (char)((third % 90) + 65);                
//            }
//            Console.WriteLine(first);
//            Console.WriteLine("{0}{1}", second, third);
//        }
//        else
//        {
//            lengthOfArray = 1 + (L - 1) * 2;
            
//            uint[] array = new uint[lengthOfArray];
//            array[0] = (uint)first;
//            array[1] = (uint)second;


//            for (int i = 2; i < lengthOfArray; i++)
//            {
//                array[i] = array[i - 1] + array[i - 2] - 65;
//                while (array[i] > 90)
//                {
//                    array[i] = ((array[i] % 90) + 65);
//                }
//            }
            
//            Console.WriteLine((char)array[0]);
//            Console.WriteLine("{0}{1}", (char)array[1], (char)array[2]);

//            string space = " ";
//            int counter = 2;

//            for (int i = 2; i != L; i++)
//            {
//                if (counter > lengthOfArray)
//                {
//                    break;
//                }

//                counter++;
//                Console.Write((char)array[counter] + space);
//                space = space + " ";
//                counter++;
//                Console.WriteLine((char)array[counter]);
//            }
//        }
//    }
//}



using System;


// this is the A-nacci problem from Practice "Telerik Academy Exam 1 @ 28 Dec 2012" 

class Anacci
{


    static void Main()
    {
        string input = Console.ReadLine();
        char first = input[0];

        input = Console.ReadLine();
        char second = input[0];
        
        int L = int.Parse(Console.ReadLine());
        int lengthOfArray = 1 + (L - 1) * 2;

        int[] array = new int[lengthOfArray];
        array[0] = (int)first;
        array[1] = (int)second;


        if (L == 1)
        {
            Console.WriteLine(first);
        }
        else if (L == 2)
        {
            char third = (char)(first + second - 65);

            array[2] = array[0] + array[1];
            while (array[2]>26)
            {
                array[2] = array[2] % 26;
            }
            
            Console.WriteLine(first);
            Console.WriteLine("{0}{1}", second, (char)(array[2] + 65));
        }
        else
        {
            for (int i = 2; i < lengthOfArray; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                while (array[i] > 26)
                {
                    array[i] = array[i] % 26;
                }
            }
            
            Console.WriteLine((char)array[0]);
            Console.WriteLine("{0}{1}", (char)array[1], (char)(array[2] + 65));

            string space = " ";
            int counter = 2;

            for (int i = L; i > 2; i--)
            {
                if (counter > lengthOfArray)
                {
                    break;
                }

                counter++;
                Console.Write((char)(array[counter] + 65) + space);
                space = space + " ";
                counter++;
                Console.WriteLine((char)(array[counter] + 65));
            }
        }
    }
}