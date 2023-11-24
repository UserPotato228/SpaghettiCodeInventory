using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Player : Character
    {
        public Player( string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public override States Attack(Character target)
        {
            Thread.Sleep(300);
            target.Health -= this.Damage;
            if (target.Health > 0) return (States.DAMAGED);
            return (States.KILLED);
        }

       /* public override string ToString()
        {
            return $"Name: {Name}; HP {Health}";
        }*/
    }
}
