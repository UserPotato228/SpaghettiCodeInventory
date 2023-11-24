using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Armor: Item
    {
        int resist;
        public Armor(int id, string name, int cost, int weight, int resist) : base(id, name, cost, weight)
        {
            Type = Types.ARMOR;
            this.resist = resist;
        }

        public int Resist
        {
            get => resist;
            set => this.resist = value;
        }
    }
}
