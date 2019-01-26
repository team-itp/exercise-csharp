using System;

namespace Calendar6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2000 年の 2 月 の日数を取得
            var daysInMonth = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("2000年2月の日数: {0}日", daysInMonth);

            // 今月の日数を取得
            var today = DateTime.Today;
            var daysInThisMonth = DateTime.DaysInMonth(today.Year, today.Month);
            Console.WriteLine("{0}年{1}月の日数: {2}日", today.Year, today.Month, daysInThisMonth);
        }
    }
}
