using ProjectRift.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities.Ships
{
    public interface IShip
    {
        int GetCurrentCargoSpace();
        int GetMaxCargoSpace();

        Boolean HasCargoSpace(int requestedSize);
        Boolean AddComponent(IModule component);
    }
}
