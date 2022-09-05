//using System;
namespace Pikaattack
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int gacha_result = rnd.Next(1, 10);
            
            if (gacha_result ==1)
            {
                Console.WriteLine("Chalizard");
            }
            else if (gacha_result !=1 && gacha_result <=7)
            {
                Console.WriteLine("Pikachu");
            }
            else
            {
                Console.WriteLine("Magikarp");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine(gacha_result);
        }
    }
}