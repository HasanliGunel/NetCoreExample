using System;

namespace Tapshiriq_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Natural ededi daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            int div = 0;
            int k = 0;
            while (number > 10 & k < 3)
            {
                div = number % 10;
                number = number / 10;
                k++;
            }
            Console.WriteLine(div);
            Console.ReadLine();
        }
    }
}
