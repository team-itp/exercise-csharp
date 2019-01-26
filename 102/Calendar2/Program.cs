using System;

namespace Calendar2
{

    class Program
    {
        static void Main(string[] args)
        {
            RenderCalendar(0);
            RenderCalendar(1);
            RenderCalendar(2);
            RenderCalendar(3);
            RenderCalendar(4);
            RenderCalendar(5);
            RenderCalendar(6);

            // startDayOfWeek を 7 以上に設定すると表示が崩れる
            RenderCalendar(7);
        }

        private static void RenderCalendar(int startDayOfWeek)
        {
            Console.WriteLine("日 月 火 水 木 金 土");

            for (var i = 0; i < startDayOfWeek; i++)
            {
                Console.Write("   ", i);
            }
            for (var i = 1; i <= 31; i++)
            {
                Console.Write("{0, 2}", i);
                if ((i + startDayOfWeek) % 7 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
