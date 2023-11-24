using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public abstract class Character : DAMAGABLE
    {
        string name;
        int health;
        int damage;
        int resist = 0;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Health
        {
            get => health;
            set { 
            if(health < 0) health = 0;
            else health = value;
            }
        }

        public int Damage 
        {
            get => damage;
            set => damage = value;
        }

        public int Resist 
        {
            get => resist;
            set => resist = value;
        }

        public override string ToString()
        {
            return $"Name: {Name}; HP: {Health}; Damage: {Damage}; Resist: {Resist}";
        }
        public abstract States Attack(Character target);
    }
}
