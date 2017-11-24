using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities
{
    public interface IWorldObject
    {
        int GetHealth();
        int GetMaxHealth();

        int GetArmor();
        int GetMaxArmor();

        int GetShield();
        int GetMaxShield();
    }
}
