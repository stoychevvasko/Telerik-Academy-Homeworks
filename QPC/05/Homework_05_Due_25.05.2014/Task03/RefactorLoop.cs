/// 03. Refactor the following loop


namespace Task03
{
    using System;    

    class RefactorLoop
    {
        public static void Main()
        {
            int[] array = new int[100];            

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                int divider = 10;
                int searchValue = 666;
                //array[50] = 666;

                if ((i % divider == 0) && (array[i] == searchValue))
                {
                    Console.WriteLine("Value found!");
                    break;
                }
            }
        }
    }
}
