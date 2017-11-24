using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities
{
    /// <summary>
    /// Base class for any object in the game
    /// </summary>
    public interface IBasicObject
    {
        // General Info
        String GetName();
        String GetDescription();

        // Size of the object
        int GetCargoSize();
        
        // Base values 
        long GetBaseValue();
    }
}
