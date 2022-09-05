//using System;
namespace Pikaattack
{
    internal class Program
    {
        static int Pika_attack(int goldduck_hp,int pika_choice)
        {
            Random dog = new Random();
            pika_choice = dog.Next(1, 10);
            //pika choice ->>
            if (pika_choice >= 3)
            {
                goldduck_hp = goldduck_hp - 15;
                Console.WriteLine("using body slam!!!");
            }
            else if (pika_choice !=3 && pika_choice >=5)
            {
                goldduck_hp = goldduck_hp - 10;
                Console.WriteLine("using thunder bolt!!");
            }
            else
            {
                goldduck_hp = goldduck_hp - 5;
                Console.WriteLine("using tackle!");
            }
            Console.WriteLine(goldduck_hp);
            return goldduck_hp;
        }
        public static void Main(string[] args)
        {
            int goldduck_hp = 100;
            int pika_choice = 3;

            /*for (int i = 0; i <= 20; i++)
            {
                goldduck_hp = Pika_attack(goldduck_hp, pika_choice);
            }*/
            for (int i = 0; i <= 20; i++)
            {
                goldduck_hp = Pika_attack(goldduck_hp, pika_choice);
                if (goldduck_hp <=0)
                {
                    Console.WriteLine("Your monster fainted out");
                    break;
                }
            }
            Console.ReadKey();
            
            //Console.WriteLine("Your monster fainted out");

        }
    }
}