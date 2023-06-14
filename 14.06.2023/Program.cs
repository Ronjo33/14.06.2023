using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._06._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mojesh da vuvedesh: Monster, Potion, Chest");
            string[] input = Console.ReadLine().Split('|');
            int health = 100;
            int coins = 0;
            int bestRoom = 0;

            foreach (string room in input)
            {
                string[] parts = room.Split();
                string eventElement = parts[0];
                int value = int.Parse(parts[1]);

                if (eventElement == "Potion")
                {
                    int healed = Math.Min(health + value, 100) - health;
                    health = Math.Min(health + value, 100);
                    Console.WriteLine($"ti se izlekuva za {healed} Hp");
                    Console.WriteLine($"v momenta si na  {health} Hp");
                }
                else if (eventElement == "Chest")
                {
                    coins += value;
                    Console.WriteLine($"ti nameri {value} moneti.");
                }
                else
                {
                    string monster = eventElement;
                    int attack = value;
                    health -= attack;
                    if (monster== "otvara")
                    {
                        break;
                    }
                    if (health > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"ti ubi {monster}.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ti umrq!!!! ti umrq ot {monster}.");
                        bestRoom++;
                        break;
                    }
                }

                bestRoom++;
            }

            if (health > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Nai dobra staq: {bestRoom}");
                Console.WriteLine("ti si TOP G");
                Console.WriteLine($"Moneti {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
