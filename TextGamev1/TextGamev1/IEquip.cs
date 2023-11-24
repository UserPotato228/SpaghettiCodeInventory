using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    public interface IEquip
    {
        void set_armor(Armor armor);
        Item remove_armor();
        void set_weapon(Weapon weapon);
        Item remove_weapon();

    }
}
