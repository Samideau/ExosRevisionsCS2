using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Location
    {
        private string _name;
        private Location[] _locationTable = new Location[5];
        private int _locationCount = 0;

        public Location(string name)
        {
            _name = name;
        }

        public string GetName() { return _name; }
        public Location GetLocationAtIndex(int index) { return _locationTable[index]; }
        public int GetLocationCount() { return _locationCount; }

        public virtual void Enter(HeroGroup hero_group_object)
        {

        }

        public void AddLocation(Location location_object)
        {
            if (_locationCount < _locationTable.Length)
            {
                _locationTable[_locationCount++] = location_object;
            }
            else
            {
                Console.WriteLine("Il n'y a plus de place pour ajouter une autre Location !");
            }
        }
    }
}
