using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS.Tests
{
    class BuildingTests
    {
        [Test]
        public void BuildingIsNotAvailableAfterBrokerRent()
        {
            //Arrange
            Building building = new Hotel("BurgasHotel", "Burgas", 5, 1200);

            //Act
            building.RentBuilding();

            //Assert
            Assert.IsFalse(building.IsAvailable);
        }
    }
}
