using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class City : Location
    {
        public City(string city_name) : base(city_name) { }

        public override void Enter(HeroGroup hero_group_object)
        {
            while (true)
            {
                //base.Enter(hero_group_object);
                Console.WriteLine($"You entered the city of {GetName()}");
                Console.WriteLine($"1. Quit the city");

                string player_input = Console.ReadLine() ?? "";

                if (player_input == "1")
                {
                    Console.WriteLine($"You left the city of {GetName()}");
                    break;
                }

                Console.WriteLine("Invalid choice: please try again");
            }

        }
    }
}
