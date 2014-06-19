using MockingDemo.Lib.Connections;
using NUnit.Framework;

namespace MockingDemo.Tests.Connections
{
    [TestFixture]
    class WirelessConnectionTests
    {
        [Test]
        public void TestDestinationSet()
        {
            // Arrange
            // Act
            var connection = new WirelessConnection("test");

            // Assert
            Assert.AreEqual("test", connection.Destination);
        }

        [Test]
        public void TestConnect()
        {
            // Arrange
            var connection = new WirelessConnection("test");

            // Act
            connection.Connect();

            // Assert
            Assert.IsTrue(connection.IsConnected);
        }

        [Test]
        public void TestDisconnect()
        {
            // Arrange
            var connection = new WirelessConnection("test");

            // Act
            connection.Connect();
            connection.Disconnect();

            // Assert
            Assert.IsFalse(connection.IsConnected);
        }
    }
}
