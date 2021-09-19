// Вариант 9.Даны переменные A, B, C. Изменить их значения, 
//переместив содержимое A в B, B — в C, C — в A, и 
//вывести новые значения переменных A, B, C.

using System;

namespace DZ1_Zhukalina_YTS_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число c:");
            int c = int.Parse(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;
            b += c;
            c = b - c;
            b -= c;

            Console.WriteLine("Меняем значения, теперь a=b, b=c, c=a:");
            Console.WriteLine($"a={a}, b={b}, c={c}");
        }
    }
}
