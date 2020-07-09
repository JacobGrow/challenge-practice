using System;
using underpressure.utils;

namespace underpressure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UnderPressure.doubleInteger(2));
            Console.WriteLine(UnderPressure.doubleInteger(5));
            Console.WriteLine(UnderPressure.doubleInteger(10));
            Console.WriteLine(UnderPressure.isNumberEven(5));
            Console.WriteLine(UnderPressure.getFileExtension("test.txt"));
            Console.WriteLine(UnderPressure.longestWord("Death be not proud.  Though some may call thee mighty and dreadful.  Thou art not so."));
            Console.WriteLine(UnderPressure.arraySum(new int[] {1, 2, 3}));

           
        }

    }
}
