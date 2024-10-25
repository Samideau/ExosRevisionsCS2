using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Mage : Hero
    {
        private Spell[] _spellTable = new Spell[5];
        private int _spellCount = 0;

        public Mage(string mage_name) : base(mage_name, "Mage") { }

        public override void Attack(Character target)
        {
            base.Attack(target);
            //TO DO
        }

        public void AddSpell(Spell spell_object) 
        {
            if (_spellCount < _spellTable.Length)
            {
                _spellTable[_spellCount++] = spell_object;
            }
            else
            {
                Console.WriteLine("Il n'y a plus de place pour apprendre un nouveau sort !");
            }
        }
    }
}
