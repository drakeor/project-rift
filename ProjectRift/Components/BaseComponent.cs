using ProjectRift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public class BaseComponent : IBasicObject, IComponent
    {
        public long GetBaseValue()
        {
            throw new NotImplementedException();
        }

        public int GetCargoSize()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int ProcessArmor(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }

        public int ProcessHealth(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }

        public int ProcessShields(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }
    }
}
