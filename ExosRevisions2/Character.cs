using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Character
    {
        private string _name;
        private int _lifeCount;

        public Character(string name, int lifeCount)
        {
            _name = name;
            _lifeCount = lifeCount;
        }

        public string GetName() { return _name; }

        public virtual void Attack(Character target)
        {
            //TO DO
        }
    }
}
