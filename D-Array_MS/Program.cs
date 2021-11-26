using System;

namespace D_Array_MS
{
    class ArrayClass2D
    {
        static void Print2DArray(string[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main()
        {
            // Pass the array as an argument.
            string Symbol_a = "string_symbol";
            string Counter_b = "string_counter_value";
            Print2DArray(new string[,] { { Symbol_a, Counter_b } });

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
    /* Output:
        Element(0,0)=1
        Element(0,1)=2
        Element(1,0)=3
        Element(1,1)=4
        Element(2,0)=5
        Element(2,1)=6
        Element(3,0)=7
        Element(3,1)=8
    */
}
