using System;

namespace SecondHomework
{
    class Program 
    {
        static void Main(string[] args)
        {
            Chair c1 = new Chair();
            SuperHero s1 = new SuperHero();
            Enemy e1 = new Enemy();

            Console.WriteLine(c1.AllofIt());
            Console.WriteLine(s1.SuperHeroStats());
            Console.WriteLine(e1.EnemyNumberone());
        }

    }
}

