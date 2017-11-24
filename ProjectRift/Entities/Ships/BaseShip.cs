using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities.Ships
{
    public class BaseShip : IShip, IBasicObject, IWorldObject
    {
        public bool AddComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public int GetArmor()
        {
            throw new NotImplementedException();
        }

        public long GetBaseValue()
        {
            throw new NotImplementedException();
        }

        public int GetCargoSize()
        {
            throw new NotImplementedException();
        }

        public int GetCurrentCargoSpace()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public int GetHealth()
        {
            throw new NotImplementedException();
        }

        public int GetMaxArmor()
        {
            throw new NotImplementedException();
        }

        public int GetMaxCargoSpace()
        {
            throw new NotImplementedException();
        }

        public int GetMaxHealth()
        {
            throw new NotImplementedException();
        }

        public int GetMaxShield()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int GetShield()
        {
            throw new NotImplementedException();
        }

        public bool HasCargoSpace(int requestedSize)
        {
            throw new NotImplementedException();
        }

        public bool ProcessDamage(int general, int shieldDam, int armorDam, int hullDam)
        {
            throw new NotImplementedException();
        }
    }
}
