using System;

namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力してください：");
            var inputText = Console.ReadLine();
            int inputNumber = 0;
            bool isPrimeNumber = true;
            if (int.TryParse(inputText, out inputNumber)　&& inputNumber > 0){
                for(int i = 2;i < inputNumber/2 + 1;i++){
                    if(inputNumber%i == 0){
                        isPrimeNumber = false;
                        break;
                    }
                }
                if(isPrimeNumber){
                    Console.WriteLine("入力した値は素数です");
                }else{
                    Console.WriteLine("入力した値は素数ではありません");    
                }

            }else{
                Console.WriteLine("入力した値は正の整数ではありません");
            }
        }
    }
}
