using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armor : Item
    {
        public int MinimumDefense { set; get; }
        public int MaximumDefense { set; get; }
        public string Type { set; get; }

        public Armor(int id, string name, string namePlural,
            int minimumDefense, int maximumDefense, 
            string type, int price) :
            base(id, name, namePlural, price)
        {
            MinimumDefense = minimumDefense;
            MaximumDefense = maximumDefense;
            Type = type;
        }
    }
}
