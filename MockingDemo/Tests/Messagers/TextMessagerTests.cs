using System;
using System.IO;
using MockingDemo.Lib.Connections;
using MockingDemo.Lib.Messagers;
using Moq;
using NUnit.Framework;

namespace MockingDemo.Tests.Messagers
{
    [TestFixture]
    class TextMessagerTests
    {
        [Test]
        public void TestSuccessfulSend()
        {
            // Arrange
            var mock = new Mock<IConnection>();
            mock.Setup(conn => conn.Connect());
            mock.Setup(conn => conn.Destination).Returns("localhost");
            var textMessager = new TextMessager(mock.Object);

            // Set the console output to a string writer, since the 
            // Send method's only side effect of a successful send 
            // is writing to stdout.
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                
                // Act
                textMessager.Send("test");

                // Assert
                string expected = String.Format("Sent text message \"test\" to localhost{0}", Environment.NewLine);
                string result = writer.ToString();
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void TestFailedSend()
        {
            // Arrange
            var mock = new Mock<IConnection>();
            mock.Setup(conn => conn.Connect()).Throws(new ConnectionException("test exception"));
            var textMessager = new TextMessager(mock.Object);

            // Set the console output to a string writer, since the 
            // Send method's only side effect of a successful send 
            // is writing to stdout.
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                // Act
                textMessager.Send("test");

                // Assert
                string expected = String.Format("test exception{0}", Environment.NewLine);
                string result = writer.ToString();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
