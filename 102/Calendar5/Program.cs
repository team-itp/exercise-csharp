using System;

namespace Calendar5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 今日の日付を取得 (今日の 00:00)
            var today = DateTime.Today;

            // DateTime 構造体のコンストラクタを使用して今月の1日を取得
            var firstDayOfThisMonth = new DateTime(today.Year, today.Month, 1);
            Console.WriteLine("今月1日: {0: yyyy/MM/dd}", firstDayOfThisMonth);

            // もしくは今日の日付から Day - 1 をしても求められる (Day が 28 の場合、27 を引くと 1 日になる)
            var firstDayOfThisMonth2 = today.AddDays(-(today.Day - 1));
            Console.WriteLine("今月1日: {0: yyyy/MM/dd}", firstDayOfThisMonth2);

            // 曜日の取得
            switch (firstDayOfThisMonth.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("今月1日は日曜日");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("今月1日は月曜日");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("今月1日は火曜日");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("今月1日は水曜日");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("今月1日は木曜日");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("今月1日は金曜日");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("今月1日は土曜日");
                    break;
                default:
                    // この処理は実行されない
                    break;
            }
            // 曜日を表示するだけなら書式を使用しても可能
            Console.WriteLine("今月1日は{0:dddd}", firstDayOfThisMonth);
        }
    }
}
