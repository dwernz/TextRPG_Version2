using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public Item ItemRequiredToEnter { set; get; }
        public Quest QuestAvaliableHere { set; get; }
        public Monster MonsterLivingHere { set; get; }
        public Location LocationToNorth { set; get; }
        public Location LocationToEast { set; get; }
        public Location LocationToSouth { set; get; }
        public Location LocationToWest { set; get; }
        public Vendor VendorWorkingHere { set; get; }

        public Location(int id, string name, string description,
            Item itemRequiredToEnter = null,
            Quest questAvaliableHere = null,
            Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvaliableHere = questAvaliableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
