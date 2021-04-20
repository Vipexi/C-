using System;
using System.Collections.Generic;

namespace StoreInformation
{
    public class MyChild
    {

        public List<string> Children = new List<string>();

        public void UnderAge()
        {


            Console.WriteLine("Give a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Give an age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Favourite bike: ");
            string bike =  Console.ReadLine();
            string child = ($"{age} {name} favourite bike: {bike}");

            Console.WriteLine($"{child}. Child has been added to the list.");
            Children.Add((child));
            
            
            
        }

       
    }
}