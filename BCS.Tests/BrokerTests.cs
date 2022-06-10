using NUnit.Framework;

namespace BCS.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BrokerMustReceiveBonus()
        {
            //Arrange
            Broker broker = new Broker("TestBroker", 19, "Burgas");
            Building building = new Hotel("BurgasHotel", "Burgas", 5, 1200);

            //Act
            double actual = broker.ReceiveBonus(building);
            double expected = building.RentAmount * 2 * building.Stars / 100;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}