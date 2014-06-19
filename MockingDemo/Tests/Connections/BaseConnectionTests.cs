using MockingDemo.Lib.Connections;
using NUnit.Framework;

namespace MockingDemo.Tests.Connections
{
    [TestFixture]
    class BaseConnectionTests
    {
        // The follow test demonstrates the use of mocks (without using
        // a mocking framework) to test the constructor of an abstract
        // base class (since you can't instantiate abstract classes by
        // themselves). Testing the constructor of a class is usually
        // pointless if your constructor is just setting values (i.e.
        // it has no logic), since that functionality will be tested
        // on every other test that uses that class anyway. This test
        // is shown for demonstration purposes only.
        [Test]
        public void TestConstructor()
        {
            // Arrange
            // Act
            var destination = "test";
            var mockBaseConnection = new MockBaseConnection(destination);

            // Assert
            Assert.AreEqual(destination, mockBaseConnection.Destination);
        }
    }

    // This mock class inherits from the BaseConection abstract class,
    // but doesn't provide any of its own implementation. Instead, it
    // soley uses the implementation provided in the abstract parent
    // class, so it can be tested.
    class MockBaseConnection : BaseConnection
    {
        public MockBaseConnection(string destination) : base(destination) { }

        public override void Connect() { }
        public override void Disconnect() { }
    }
}
