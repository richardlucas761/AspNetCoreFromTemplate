using AspNetCoreFromTemplate.Services;
using FluentAssertions;

namespace AspNetCoreFromTemplate.Tests
{
    [TestClass]
    public sealed class WelcomeServiceTests()
    {
        WelcomeService? _welcomeService;

        [TestInitialize]
        public void Setup()
        {
            _welcomeService = new WelcomeService();
        }

        [TestMethod]
        public void GetWelcomeMessage()
        {
            // Arrange
            var expectedMessage = $"Welcome to Contoso! The current time is {_welcomeService._serviceCreated}. This service instance has an ID of {_welcomeService._serviceId}";

            // Act
            var response = _welcomeService.GetWelcomeMessage();

            // Assert
            response.Should().Be(expectedMessage);
        }
    }
}
