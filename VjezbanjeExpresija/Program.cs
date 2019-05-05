using System;

namespace VjezbanjeExpresija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestingClass.Test(12, 7));
            Console.WriteLine(TestingClass.BinExp());
            Console.WriteLine(TestingClass.FinalBinExp());
            TestingClass.ArayExample();
            Console.ReadLine();
        }
    }
}
