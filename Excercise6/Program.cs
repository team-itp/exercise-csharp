using System;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<+100;i++){
                if(i%5 == 0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
            }
        }
    }
}
