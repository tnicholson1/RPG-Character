using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RPGcharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your characters name. It must be at least five characters long.");
            name = Console.ReadLine();
            char first = name[0];
            char second = name[1];
            char third = name[2];
            if (first == 'A')
            {
                var random = new Random();
                var list = new List<string> { "Mercenary", "Barbarian"};
                int index = random.Next(list.Count);
                Console.WriteLine("Your class is " + list[index]);
            }
            else
            {
                var random = new Random();
                var list = new List<string> { "Bard", "Mage", "Paladin" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your class is " +list[index]);
            }
            Console.ReadKey();

            if (second == 'g')
            {
                var random = new Random();
                var list = new List<string> { "65", "70", "75", "80" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your strength is " + list[index] + "/100");
            }
            else if (second == 'h')
            {
                var random = new Random();
                var list = new List<string> { "25", "30", "35", "40" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your strength is " + list[index] + "/100");
            }
            else if (second == 'r')
            {
                var random = new Random();
                var list = new List<string> {"85", "90", "95", "100" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your strength is " + list[index] + "/100");
            }
            else if (second == 'l')
            {
                var random = new Random();
                var list = new List<string> { "5", "10", "15", "20" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your strength is " + list[index] + "/100");
            }
            else
            {
                var random = new Random();
                var list = new List<string> { "45", "50", "55", "60" };
                int index = random.Next(list.Count);
                Console.WriteLine("Your strength is " + list[index] + "/100");
            }
            Console.ReadKey();

            Random rnd = new Random();
            int age = rnd.Next(18, 65);

            Console.WriteLine("Your age is " + age);
            Console.ReadKey();

            if (age >= 18 && age <= 35)
            {
                var random = new Random();
                var list = new List<string> { "speed", "strength", "fighting", "stamina"};
                int index = random.Next(list.Count);
                Console.WriteLine("Your " + list[index] + "is 100/100");
            }
            else
            {
                var random = new Random();
                var list = new List<string> { "conversation", "trading", "intelligence"};
                int index = random.Next(list.Count);
                Console.WriteLine("Your " + list[index] + "is 100/100");

            }
            Console.ReadKey();


        }
    }
}
