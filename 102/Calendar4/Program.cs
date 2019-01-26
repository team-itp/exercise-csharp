using System;

namespace Calendar4
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            Console.WriteLine("今日の日付: " + today.ToLongDateString());

            // DateTime 構造体を new しても今日の日付にはならない
            var newDate = new DateTime();
            Console.WriteLine("new した DateTime 構造体: " + newDate);

            // DateTime 構造体には年・月・日・時間・分・秒を取得するプロパティが存在する
            Console.Write(today.Year + "年" + today.Month + "月" + today.Day + "日 ");
            Console.WriteLine(today.Hour + "時" + today.Minute + "分" + today.Second + "秒");

            // DateTime 構造体にはそれ以外にもいろいろなメソッドが用意されている
            Console.WriteLine("明日: {0}", today.AddDays(1));
            Console.WriteLine("来月: {0}", today.AddMonths(1));
            Console.WriteLine("来年: {0}", today.AddYears(1));
        }
    }
}
