using MVPDemo.Models;
using NUnit.Framework;

namespace MVPDemo.Tests.Models
{
    [TestFixture]
    class CapitalizerTests
    {
        [Test]
        public void CapitalizeShouldActuallyCapitalize()
        {
            // Arrange
            var capitalizer = new Capitalizer();

            // Act
            string result = capitalizer.Capitalize("test");

            // Assert
            Assert.AreEqual("TEST", result);
        }
    }
}
