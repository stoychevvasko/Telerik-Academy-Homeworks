//01. Refactor the following examples to produce code with well-named C# identifiers:

using System;

class BooleanData
{
    const int MAX_COUNT = 5;
    class Methods
    {
        void printToConsole(bool booleanArgument)
        {
            string booleanAsString = booleanArgument.ToString();
            Console.WriteLine(booleanAsString);
        }
    }

    public static void InputData()
    {
        BooleanData.Methods method = new BooleanData.Methods();
        method.printToConsole(true);
    }
}
