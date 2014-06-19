using MockingDemo.Lib.Connections;
using NUnit.Framework;

namespace MockingDemo.Tests.Connections
{
    [TestFixture]
    class NetworkConnectionTests
    {
        [Test]
        public void TestDestinationSet()
        {
            // Arrange
            // Act
            var connection = new NetworkConnection("test");

            // Assert
            Assert.AreEqual("test", connection.Destination);
        }

        [Test]
        public void TestConnect()
        {
            // Arrange
            var connection = new NetworkConnection("test");

            // Act
            connection.Connect();

            // Assert
            Assert.IsTrue(connection.IsConnected);
        }

        [Test]
        public void TestDisconnect()
        {
            // Arrange
            var connection = new NetworkConnection("test");

            // Act
            connection.Connect();
            connection.Disconnect();

            // Assert
            Assert.IsFalse(connection.IsConnected);
        }
    }
}
