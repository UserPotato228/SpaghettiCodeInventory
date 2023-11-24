using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Weapon : Item
    {
        int damage;
        public Weapon(int id, string name, int cost, int weight, int damage) : base(id, name, cost, weight)
        {
            this.Type = Types.WEAPON;
            this.damage = damage;
        }

        public int Damage 
        {
            get => damage;
            set => this.damage = value;
        }
    }
}
