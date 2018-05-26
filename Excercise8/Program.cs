using System;

namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください：");
            var inputText = Console.ReadLine();
            int inputNumber = 0;
            if (int.TryParse(inputText, out inputNumber)){
                Console.WriteLine("入力した値は整数です");
            }else{
                Console.WriteLine("入力した値は整数ではありません");
            }
        }
    }
}
