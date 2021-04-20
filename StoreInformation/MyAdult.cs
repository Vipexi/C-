using System;
using System.Collections.Generic;

namespace StoreInformation
{
    public class MyAdult
    {
        public List<string> Adults = new List<string>();
        public void OverAge()
        {
            
            Console.WriteLine("Give a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Give an age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Favourite bike: ");
            string car =  Console.ReadLine();
            string adult = ($"{age} {name} favourite bike: {car}");

            Console.WriteLine($"{adult}. Adult has been added to the list.");
            Adults.Add((adult));
            

        }
    }
}