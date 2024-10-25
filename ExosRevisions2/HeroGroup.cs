using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class HeroGroup
    {
        private Hero[] _heroTable = new Hero[5];
        private int _heroCount = 0;

        public void AddHero(Hero hero_object)
        {
            if(_heroCount < _heroTable.Length) 
            {
                _heroTable[_heroCount++] = hero_object;
            }
            else
            {
                Console.WriteLine("Il n'y a plus de place dans le groupe !");
            }
        }

        public void Attack(Character current_enemy)
        {
            for(int i = 0; i < _heroCount; i++)
            {
                _heroTable[i].Attack(current_enemy);
            }
        }
    }
}
