using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public interface IComponent
    {
        int ProcessShields(int baseValue, int currentValue);
        int ProcessArmor(int baseValue, int currentValue);
        int ProcessHealth(int baseValue, int currentValue);
    }
}
