using NUnit.Framework;
using ProjectRift.Entities.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRiftGameplay.Test.ShipCombat
{
    public class MockShip : BaseShip
    {
        public override int GetMaxShield()
        {
            return 10;
        }
        public override int GetMaxHealth()
        {
            return 10;
        }
        public override int GetMaxArmor()
        {
            return 10;
        }
    }

    [TestFixture]
    public class ShipDamageTests
    {
        [Test]
        public void GeneralDamage_Minor()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(5, 0, 0);
            Assert.AreEqual(5, mockShip.GetShield());
            Assert.AreEqual(10, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void GeneralDamage_Moderate()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(15, 0, 0);
            Assert.AreEqual(0, mockShip.GetShield());
            Assert.AreEqual(5, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void GeneralDamage_Major()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(25, 0, 0);
            Assert.AreEqual(0, mockShip.GetShield());
            Assert.AreEqual(0, mockShip.GetArmor());
            Assert.AreEqual(5, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void GeneralDamage_Fatal()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(35, 0, 0);
            Assert.AreEqual(0, mockShip.GetShield());
            Assert.AreEqual(0, mockShip.GetArmor());
            Assert.AreEqual(-5, mockShip.GetHealth());
            Assert.IsFalse(isAlive);
        }

        [Test]
        public void CombinedDamage_Test()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(5, 3, 5);
            Assert.AreEqual(2, mockShip.GetShield());
            Assert.AreEqual(5, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void ShieldOnlyDamage_Minor()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 1, 0);
            Assert.AreEqual(9, mockShip.GetShield());
            Assert.AreEqual(10, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void ShieldOnlyDamage_Major()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 100, 0);
            Assert.AreEqual(0, mockShip.GetShield());
            Assert.AreEqual(10, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void PiercingOnlyDamage_MinorArmor()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 0, 1);
            Assert.AreEqual(10, mockShip.GetShield());
            Assert.AreEqual(9, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void PiercingOnlyDamage_DepleteArmor()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 0, 10);
            Assert.AreEqual(10, mockShip.GetShield());
            Assert.AreEqual(0, mockShip.GetArmor());
            Assert.AreEqual(10, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void PiercingOnlyDamage_BleedToHull()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 0, 15);
            Assert.AreEqual(10, mockShip.GetShield());
            Assert.AreEqual(0, mockShip.GetArmor());
            Assert.AreEqual(5, mockShip.GetHealth());
            Assert.IsTrue(isAlive);
        }

        [Test]
        public void PiercingOnlyDamage_Fatal()
        {
            MockShip mockShip = new MockShip();
            var isAlive = mockShip.ProcessDamage(0, 0, 25);
            Assert.AreEqual(10, mockShip.GetShield());
            Assert.AreEqual(0, mockShip.GetArmor());
            Assert.AreEqual(-5, mockShip.GetHealth());
            Assert.IsFalse(isAlive);
        }

    }
}
