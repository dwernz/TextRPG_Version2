using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int MaximumDamage { set; get; }
        public int RewardExperiencePoints { set; get; }
        public int RewardGold { set; get; }

        public List<LootItem> LootTable { set; get; }

        public Monster(int id, string name, int maximumDamage,
            int rewardExperiencePoints, int rewardGold,
            int currentHitPoints, int maximumHitPoints) :
            base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();
        }
    }
}
