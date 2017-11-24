using FakeItEasy;
using NUnit.Framework;
using ProjectRift.Components;
using ProjectRift.Entities.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRiftGameplay.Test.Components
{
    class MockModuleShip : BaseShip
    {
        public override int GetMaxCargoSpace()
        {
            return 6;
        }
    }

    [TestFixture]
    public class ModuleManipulationTests
    {
        [Test]
        public void Test_AddToCapacity()
        {
            // The module we add has a cargo size of 2
            var fakeModule = A.Fake<IModule>();
            A.CallTo(() => fakeModule.GetCargoSize()).Returns(2);

            // The ship we create has a cargo hold of 6
            IShip ship = new MockModuleShip();
            Assert.AreEqual(0, ship.GetCurrentCargoSpace());
            Assert.IsTrue(ship.HasCargoSpace(fakeModule.GetCargoSize()));

            // Adding a module should bring us to 2 and return true
            Assert.IsTrue(ship.AddModule(fakeModule));
            Assert.AreEqual(2, ship.GetCurrentCargoSpace());

            // Adding a module should bring us to 4 and return true
            Assert.IsTrue(ship.AddModule(fakeModule));
            Assert.AreEqual(4, ship.GetCurrentCargoSpace());

            // Adding a module should bring us to 6 and return true
            Assert.IsTrue(ship.AddModule(fakeModule));
            Assert.AreEqual(6, ship.GetCurrentCargoSpace());

            var cargo = ship.GetMaxCargoSpace();

            // Adding a module should keep us at 6 and return false
            Assert.IsFalse(ship.AddModule(fakeModule));
            Assert.AreEqual(6, ship.GetCurrentCargoSpace());

        }
    }
}
