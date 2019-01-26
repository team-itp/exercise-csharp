using System;

namespace Calendar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("日 月 火 水 木 金 土");
            for (var i = 1; i <= 31; i++)
            {
                Console.Write("{0, 2}", i);
                if (i % 7 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ", i);
                }
            }
        }
    }
}
