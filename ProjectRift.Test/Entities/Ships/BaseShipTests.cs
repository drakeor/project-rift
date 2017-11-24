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
        [Test()]
        public void AddComponentTest()
        {
            BaseShip baseShip = new BaseShip();
            baseShip.AddComponent(new BaseModule());
        }

        [Test()]
        public void GetArmorTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetBaseValueTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetCargoSizeTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetCurrentCargoSpaceTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetDescriptionTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetHealthTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetMaxArmorTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetMaxCargoSpaceTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetMaxHealthTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetMaxShieldTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetNameTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void GetShieldTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void HasCargoSpaceTest()
        {
            BaseShip baseShip = new BaseShip();
        }

        [Test()]
        public void ProcessDamageTest()
        {
            BaseShip baseShip = new BaseShip();
        }
    }
}