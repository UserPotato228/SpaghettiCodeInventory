using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public class Equipment : IEquip
    {
        Item weapon;
        Item armor;
        Player carrier;
        public Equipment(Player player) 
        {
            carrier = player;
        }
        public void set_armor(Armor armor)
        {
            Console.WriteLine($"Вы применили \"{armor.Name}\". Ваше сопротивление урону состовляет {armor.Resist}");
            this.armor = armor;
            carrier.Resist = armor.Resist;
        }
        public Item remove_armor()
        {
            throw new NotImplementedException();
        }


        public Item remove_weapon()
        {
            throw new NotImplementedException();
        }

        public void set_weapon(Weapon weapon)
        {
            Console.WriteLine($"Вы применили \"{weapon.Name}\". Ваш дамаг состовляет {weapon.Damage}");
            this.weapon = weapon;
            carrier.Damage = weapon.Damage;
        }
    }
}
