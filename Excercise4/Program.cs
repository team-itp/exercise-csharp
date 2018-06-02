using System;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力してください：");
            var inputText = Console.ReadLine();
            Console.WriteLine("入力値：" + inputText);

            var inputNumber = 0;
            if (!int.TryParse(inputText, out inputNumber))
            {
                Console.WriteLine("整数に変換できません");
                return;
            }

            if (inputNumber <= 0)
            {
                Console.WriteLine("正の整数を入力してください");
                return;
            }

            for (var i = 1; i <= inputNumber; i++)
            {
                Console.WriteLine(i + "回目：Hello, World");
            }
        }
    }
}
