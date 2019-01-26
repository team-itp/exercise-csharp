using System;

namespace Calendar7
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            ShowCalendar(today.Year, today.Month);

            Console.WriteLine("1年分のカレンダー");
            for (var i = 1; i <= 12; i++)
            {
                ShowCalendar(today.Year, i);
            }
        }

        private static void ShowCalendar(int year, int month)
        {
            var firstDayOfMonth = new DateTime(year, month, 1);
            Console.WriteLine("{0}年{1}月", year, month);
            // DayOfWeek は (都合がいいことに) 日曜日が 0 → 土曜日が 6 のintに変換できる
            RenderCalendar((int)firstDayOfMonth.DayOfWeek, DateTime.DaysInMonth(year, month));
            Console.WriteLine();
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
