using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Warrior : Hero
    {
        public Warrior(string warrior_name) : base(warrior_name, "Warrior") { }

        public override void Attack(Character target)
        {
            base.Attack(target);
            //TO DO
        }
    }
}
