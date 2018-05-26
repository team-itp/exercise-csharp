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

            int inputNumber = 0;
            if (int.TryParse(inputText, out inputNumber) && inputNumber > 0){
                for(int i = 1;i <= inputNumber;i++){
                    Console.WriteLine( i + "回目：Hello, World");
                }
            }else{
                Console.WriteLine("正の整数に変換できません");
            }
        }
    }
}
