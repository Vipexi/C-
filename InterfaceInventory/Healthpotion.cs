using System;

namespace InterfaceInventory
{
    public class HealthPotion : IInventoryItem
    {
        public string Name {get; set;}

        public string Type {get; private set;}

        public int HPGain {get; private set;}

        public HealthPotion(string name, int hp)
        {
            Name = name;
            HPGain = hp;
        }

        public void Use()
        {
            Console.WriteLine("The player gained hp!");
        }
    }
}