using System;

namespace Calendar3
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderCalendar(0, 28);
            RenderCalendar(0, 30);
            RenderCalendar(0, 31);

            RenderCalendar(1, 30);
        }

        private static void RenderCalendar(int startDayOfWeek, int lengthOfMonth)
        {
            Console.WriteLine("日 月 火 水 木 金 土");

            for (var i = 0; i < startDayOfWeek; i++)
            {
                Console.Write("   ", i);
            }
            for (var i = 1; i <= lengthOfMonth; i++)
            {
                Console.Write("{0, 2}", i);
                if ((i + startDayOfWeek) % 7 == 0 || i == lengthOfMonth)
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
