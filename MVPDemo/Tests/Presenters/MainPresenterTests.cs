using System;
using Moq;
using MVPDemo.Models;
using MVPDemo.Presenters;
using MVPDemo.Views.Main;
using NUnit.Framework;

namespace MVPDemo.Tests.Presenters
{
    [TestFixture]
    class MainPresenterTests
    {
        [Test]
        public void HandleCapitalizeButtonClicked_TakesInputAndSetsOutput()
        {
            // Arrange
            // Create a mock view, for testing purposes.
            var mockView = new Mock<IMainView>();
            mockView.Setup(view => view.InputText).Returns("test");
            mockView.SetupProperty(view => view.OutputText);

            // Mock the capitalizer dependency because the presenter should
            // not care about the data output (because that is the job of the
            // capitalizer). Instead, we are simply testing whether the
            // presenter properly sets the output of the view. Because of this,
            // we set the capitalizer mock to just return nonsense ("foo") so
            // we can easily verify it in a test. The capitalizer class has 
            // its own unit tests, which tests its behavior independently, so
            // we still maintain testing code coverage.
            var mockCapitalizer = new Mock<ICapitalizer>();
            mockCapitalizer.Setup(model => model.Capitalize(It.IsAny<string>()))
                .Returns("foo");

            // Instantiate our presenter, using depedendency injection to pass
            // in the view and model dependencies.
            var mainPresenter = new MainPresenter(mockView.Object, mockCapitalizer.Object);

            // Act
            mockView.Raise(view => view.CapitalizeButtonClicked += null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("foo", mainPresenter.View.OutputText);
        }

        [Test]
        public void HandleInitialize_SetsOutputTextToDashes()
        {
            // Arrange
            var mockView = new Mock<IMainView>();

            // Mock ICapitalizer because we don't care about anything 
            // capitalizer related for this test.
            var mockCapitalizer = new Mock<ICapitalizer>();
            mockView.SetupAllProperties();
            var mainPresenter = new MainPresenter(mockView.Object, mockCapitalizer.Object);
            
            // Act
            // This example shows how to raise events with Moq.
            // Documentation: https://github.com/Moq/moq4/wiki/Quickstart
            mockView.Raise(view => view.Initialize += null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("---", mainPresenter.View.OutputText);
        }

        [Test]
        public void HandleLoadView_SetsViewLoadedToTrue()
        {
            // Arrange
            var mockView = new Mock<IMainView>();
            var mockModel = new Mock<ICapitalizer>();
            mockView.SetupAllProperties();
            var mainPresenter = new MainPresenter(mockView.Object, mockModel.Object);

            // Act
            mockView.Raise(view => view.LoadView += null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(true, mainPresenter.ViewLoaded);
        }
    }
}
