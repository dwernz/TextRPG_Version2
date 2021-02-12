using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Spell
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int MinimumDamage { set; get; }
        public int MaximumDamage { set; get; }
        public string Element { set; get; }

        public Spell(int id, string name, int minimumDamage,
            int maximumDamage, string element)
        {
            ID = id;
            Name = name;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            Element = element;
        }
    }
}
