using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForceRPG.Classes.Attacks
{
    class NormalDamage : AttackController
    {
        public NormalDamage() : base("Punch", 10, 35, 5, false)
        {

        }
    }
}
