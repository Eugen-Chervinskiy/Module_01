using Module_01.Task_1;
using System;


namespace Module_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SumCalculator.SumByForLoop(1,2,3,-2,3f));

            Console.WriteLine(SumCalculator.SumByWhileLoop(1, 2, 3.00333d, -2, 3f));

            Console.WriteLine(SumCalculator.SumByRecursion(null));

            Console.ReadKey();
        }
    }
}
