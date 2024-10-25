using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExosRevisions2
{
    internal class Enemy : Character
    {
        private int _rewardValue;

        public Enemy(string enemy_name, int enemy_life_count, int enemy_reward_value) : base(enemy_name, enemy_life_count)
        {
            _rewardValue = enemy_reward_value;
        }
    }
}
