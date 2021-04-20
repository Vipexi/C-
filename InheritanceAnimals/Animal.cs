using System;

namespace InheritanceAnimals
{
    
    /*static class AnimalStats
    {
        //doesn't work, because instance member
        //private int count = 0;
        public static float CalculateEyesToLegsRatio(Animal animal)
        {
            return (float)animal.EyeCount / animal.LegCount;
        }
    }*/

    public class Animal
    {
        // instance members
        public int LegCount {get; protected set;}

        public int EyeCount{get; protected set;}

        // class member
        public static int Count {get; private set;} = 0;

        public Animal() { }

        public Animal (int legs, int eyes=2)
        {
            LegCount = legs;
            EyeCount = eyes;
            Count = Count + 1;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sounds!");
        }

        public static void StaticAnimal()
        {
            Console.WriteLine("StaticAnimal() called!");
        }
    }
}