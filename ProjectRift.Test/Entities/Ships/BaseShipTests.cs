using NUnit.Framework;
using ProjectRift.Components;
using ProjectRift.Entities.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities.Ships.Tests
{
    [TestFixture()]
    public class BaseShipTests
    {
        /// <summary>
        /// Should allow to add a component to the base ship
        /// since the base ship has no components by default
        /// </summary>
        [Test()]
        public void AddComponentTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.IsTrue(baseShip.AddComponent(new BaseModule()));
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetArmorTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetArmor(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetBaseValueTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetBaseValue(), 0);
        }
        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetCargoSizeTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetCargoSize(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetCurrentCargoSpaceTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetCurrentCargoSpace(), 0);
        }

        /// <summary>
        /// Make sure a description exists
        /// </summary>
        [Test()]
        public void GetDescriptionTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.AreNotEqual(0, baseShip.GetDescription().Length);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetHealthTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetHealth(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetMaxArmorTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetMaxArmor(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetMaxCargoSpaceTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetMaxCargoSpace(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetMaxHealthTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetMaxHealth(), 0);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetMaxShieldTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetMaxShield(), 0);
        }

        /// <summary>
        /// Has a name
        /// </summary>
        [Test()]
        public void GetNameTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.AreNotEqual(0, baseShip.GetName().Length);
        }

        /// <summary>
        /// Make sure is greater than 0
        /// </summary>
        [Test()]
        public void GetShieldTest()
        {
            BaseShip baseShip = new BaseShip();
            Assert.Greater(baseShip.GetMaxShield(), 0);
        }

        /// <summary>
        /// A tiny object with no cargo space should pass
        /// </summary>
        [Test()]
        public void HasCargoSpaceTest_TinyObject()
        {
            BaseShip baseShip = new BaseShip();
            Assert.IsTrue(baseShip.HasCargoSpace(0));
        }

        /// <summary>
        /// A massive object should obviously fail
        /// </summary>
        [Test()]
        public void HasCargoSpaceTest_MassiveObject()
        {
            BaseShip baseShip = new BaseShip();
            Assert.IsFalse(baseShip.HasCargoSpace(int.MaxValue));
        }

        /// <summary>
        /// No damage is not enough to kill the ship
        /// </summary>
        [Test()]
        public void ProcessDamageTest_NoDamage()
        {
            BaseShip baseShip = new BaseShip();
            Assert.IsTrue(baseShip.ProcessDamage(0, 0, 0, 0));
        }

        /// <summary>
        /// Maxed out damage is enough to kill the ship
        /// </summary>
        [Test()]
        public void ProcessDamageTest_MassiveDamage()
        {
            BaseShip baseShip = new BaseShip();
            Assert.IsTrue(baseShip.ProcessDamage(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue));
        }
    }
}