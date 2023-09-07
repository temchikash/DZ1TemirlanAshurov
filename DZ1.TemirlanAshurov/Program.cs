using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1TemirlanAshurov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");

            Console.WriteLine("2 задание");
            Console.WriteLine("Введите первое число:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string num2 = Console.ReadLine();
            Console.WriteLine("{0} , {1}", num2, num1);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите радиус окружности:");
            double rad = uint.Parse(Console.ReadLine());

            double len = rad * Math.PI * 2;
            double square = Math.PI * Math.Pow(rad, 2);
            Console.WriteLine($"Длина окружности круга с радиусом {rad} равна {len}, а площадь равна {square}");


            Console.WriteLine("4 задание");
            Console.WriteLine("Введите x:");
            double x = int.Parse(Console.ReadLine());
            double sin = Math.Sin(x);
            Console.WriteLine($"Синус числа {x} равен: {sin}");

            Console.WriteLine("7 задание");
            Random numb = new Random();
            Console.WriteLine($"{numb.Next()}\n");
            Console.WriteLine($"{numb.Next()}\n");
            Console.WriteLine($"{numb.Next()}\n");
            Console.WriteLine($"{numb.Next()}\n");

            Console.WriteLine("8 задание");
            string aa = Console.ReadLine();
            Console.WriteLine(aa[2] + aa.Remove(2));

            Console.WriteLine("9 задание");
            Console.WriteLine("кг конфет - 30 рублей. Сколько кг вы хотите?");
            int candy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кг печенья - 120 рублей. Сколько кг вы хотите?");
            int cook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кг яблок - 20 рублей. Сколько кг вы хотите?");
            int apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(apple * 20 + cook * 120 + candy * 30);


            Console.ReadKey();
        }
    }
}
