//3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
using System;

namespace Home_Work2._2
{
    class Program
    {
        private static void myNumber()
        {
            
            
            int inputNum = 1;
            int result = 0;
            while (inputNum != 0) 
            {
                Console.WriteLine("Введите число. Чтобы завершить введите 0.");
                inputNum = int.Parse(Console.ReadLine());
                
                if (inputNum % 2 != 0 && inputNum > 0) result+= inputNum;
            }
            
         
            Console.Write($"Сумма всех нечётных чисел введённых вами состовляет: {result}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n\n");
            myNumber();


        }
    }
}
