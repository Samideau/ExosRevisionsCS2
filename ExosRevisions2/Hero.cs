using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal abstract class Hero : Character
    {
        private string _className;
        private int _xp;
        private int _money;

        public Hero(string hero_name, string hero_class_name) : base(hero_name, 100)
        {
            _className = hero_class_name;
            _xp = 0;
            _money = 0;
        }
    }
}
