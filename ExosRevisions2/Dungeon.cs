using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Dungeon : Location
    {
        private Enemy[] _enemyTable = new Enemy[5];

        public Dungeon() : base("Dungeon") 
        {
            _enemyTable[0] = new Enemy("Kobold Scout", 6, 10);
            _enemyTable[1] = new Enemy("Goblin Grunt", 12, 100);
            _enemyTable[2] = new Enemy("Orc Warrior", 24, 1000);
            _enemyTable[3] = new Enemy("Stone Golem", 48, 10000);
            _enemyTable[4] = new Enemy("Ancient Dragon", 96, 100000);

        }

        public override void Enter(HeroGroup hero_group_object)
        {
            while (true)
            {
                Console.WriteLine("You entered a dark dungeon");
                Console.WriteLine("1. Enter the dungeon");
                Console.WriteLine("2. Leave");

                string player_input = Console.ReadLine() ?? "";

                if (player_input == "1")
                {
                    Console.WriteLine($"You have entered the dungeon");

                    for (int enemy_index = 0; enemy_index < _enemyTable.Length; enemy_index++)
                    {
                        Enemy current_enemy = _enemyTable[enemy_index];

                        Console.WriteLine($"Your next encounter is a {current_enemy.GetName()}");
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("1. Attack");
                        Console.WriteLine("2. Leave the dungeon");

                        player_input = Console.ReadLine() ?? "";

                        if (player_input == "1")
                        {
                            hero_group_object.Attack(current_enemy);
                        }
                        else if (player_input == "2")
                        {
                            Console.WriteLine($"You left the dungeon");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice: please try again");
                        }
                    }

                    Console.WriteLine("You completed the dungeon, your party decide to leave this dungeon");
                    break;
                }
                else if (player_input == "2")
                {
                    break;
                }

                Console.WriteLine("Invalid choice: please try again");
            }

        }
    }
}
