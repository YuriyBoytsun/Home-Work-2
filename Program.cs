//4. Реализовать метод проверки логина и пароля.
//На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел
//(Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.
using System;

namespace Home_Work2._3
{
    class Program
    {
         static bool myLogIn()
        {
            string loginInput = "", passwordInput = "";
            int i = 0;
            string login = "root", password = "GeekBrains";
           
                Console.WriteLine($"Количество попыток {3 - i} !");
                do
                {
                    Console.Write("Введите логин:");
                    loginInput = Console.ReadLine();
                    Console.Write("Введите пароль:");
                    passwordInput = Console.ReadLine();
                    i++;

                    if (loginInput == login && passwordInput == password)break; 

                    Console.WriteLine($"Данные не верны, количество оставшихся попыток {3 - i} !");
                    
                    continue;
                }
                while (i < 3);

                if (loginInput == login && passwordInput == password)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Доступ разрешён!");
                        Console.ReadLine();
                        return true;
                    }
                else 
                    {
                        Console. ForegroundColor = ConsoleColor. Red;
                        Console.WriteLine("В доступе отказано!");
                        Console.ReadLine();
                        return false;
                    }

           


        }
        static void Main(string[] args)
        {
            Console.WriteLine(@" 
Реализовать метод проверки логина и пароля.
На вход метода подается логин и пароль. 
На выходе истина, если прошел авторизацию, и ложь, если не прошел 
(Логин: root, Password: GeekBrains). 
Используя метод проверки логина и пароля, 
написать программу: пользователь вводит логин и пароль,
программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.");
            Console.WriteLine("\n\n");

            

            myLogIn();
            




        }
    }
}
