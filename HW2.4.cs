/*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
    нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

using System;

namespace Home_Work2._4
{
    class Program
    {
        static string Health(int mass, double height)
        {
            double I = mass / (Math.Pow(height, 2));

            string ratio = "";
            if (I < 18.5) 
            {
                double toGain = (Math.Pow(height, 2)) * (18.5 - I);
                ratio = $"У вас дефицит массы тела. Вам нужно набрать {toGain:F2} кг!"; 
            }

            else if (I > 25) 
            { 
                double toLose = (Math.Pow(height, 2)) * (I - 25);
                ratio = $"У вас переизбыток массы тела. Вам нужно сбросить {toLose:F2} кг!"; 
            }

            else { ratio = "Ваша массы тела в норме."; }


            string result = $"Индекс массы вашего тела составляет {I:F2}. "+ ratio;
;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Написать программу, которая запрашивает массу и рост человека,
вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.WriteLine("\n\n");
           

            Console.Write("Ваш вес в килограммах: ");
            int imass = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ваш рост в метрах через точку: ");
            double iheight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Health(imass, iheight));
            Console.ReadLine();
        }
    }
}
