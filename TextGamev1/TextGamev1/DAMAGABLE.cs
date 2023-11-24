using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGamev1
{
    interface DAMAGABLE
    {
        States Attack(Character targer);
    }
}
