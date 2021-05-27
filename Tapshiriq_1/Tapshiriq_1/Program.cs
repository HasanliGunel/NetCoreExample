using System;

namespace Tapshiriq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girish metni:");
            string g_m = Console.ReadLine();
            int m = g_m.Length;
            for (int i = m - 1; i >= 0; i--)
            {
                Console.Write(g_m[i]);
            }
            Console.ReadLine();
        }
    }
}
