using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreInformation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Have done the lists of adults and children.
            // Asked for user input
            // Added the user input into the lists
            // Have to still do the three classes
            // and make the whole thing modular

            MyChild p1 = new MyChild();

            MyAdult p2 = new MyAdult();

            //Console.WriteLine(p1.Children);
            //Console.WriteLine(p2.Adults);

            
                while (true)
                {    
                    Console.WriteLine("If you want to add a person type 'yes': ");

                    string answer = Console.ReadLine();
                    if (answer == "yes")
                        AskUser();
                    
                    if (answer != "yes")
                        Console.WriteLine("If you want to quit type 'yes': ");
                        string decision = Console.ReadLine();
                        if (decision == "yes")
                            break; 

                }
                
            

            void AskUser()
                {    
                    Console.WriteLine("Do you want to add a 'child' or  and 'adult': ");
                    
                    string age = Console.ReadLine();


                    if (age == "child")
                    {
                        p1.UnderAge();
                    }
                    
                    else if (age=="adult")
                    {
                        p2.OverAge();
                    }

                    else
                    {
                        AskUser();
                    }
                }
            
            //List<string> AllCharacters = p1.Children.Concat(p2.Adults).ToList();
            //AllCharacters.ForEach(Console.WriteLine);
            
            p1.Children.ForEach(Console.WriteLine);
            p2.Adults.ForEach(Console.WriteLine);

        }
    }
}

