using System;

namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力してください：");
            var inputText = Console.ReadLine();
            var inputNumber = 0;

            if (!int.TryParse(inputText, out inputNumber))
            {
                Console.WriteLine("入力した値は整数ではありません");
                return;
            }

            if (inputNumber <= 0)
            {
                Console.WriteLine("入力した値は正の整数ではありません");
                return;
            }

            var isPrimeNumber = true;

            for (var i = 2; i < inputNumber / 2 + 1; i++)
            {
                if (inputNumber % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            
            if (isPrimeNumber)
            {
                Console.WriteLine("入力した値は素数です");
            }
            else
            {
                Console.WriteLine("入力した値は素数ではありません");
            }
        }
    }
}
