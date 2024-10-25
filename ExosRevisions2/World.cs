using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class World : Location
    {
        public World() : base("World") { }

        public override void Enter(HeroGroup hero_group_object)
        {
            while(true)
            {
                //base.Enter(hero_group_object);
                int compteur_location = 0;
                while (compteur_location < GetLocationCount())
                {
                    Console.WriteLine($"{compteur_location + 1}. Explore {GetLocationAtIndex(compteur_location).GetName()}");
                    compteur_location++;
                }

                Console.WriteLine($"{compteur_location + 1}. Explore a random dungeon");
                Console.WriteLine($"{compteur_location + 2}. Quit the world");

                int player_input = -1;
                string player_text_input = Console.ReadLine() ?? "";

                try
                {
                    player_input = int.Parse(player_text_input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    player_input = -1;
                }

                if ((player_input > 0) && (player_input <= GetLocationCount()))
                {
                    GetLocationAtIndex(player_input - 1).Enter(hero_group_object);
                }
                else if (player_input == compteur_location + 1)
                {
                    Dungeon dungeon = new Dungeon();

                    dungeon.Enter(hero_group_object);
                }
                else if (player_input == compteur_location + 2)
                {
                    Console.WriteLine("You have left the world!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice: please try again");
                }
            }
        }
    }
}
