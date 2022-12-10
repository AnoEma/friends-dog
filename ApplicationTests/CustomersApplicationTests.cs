using Application.services;
using Domain.Entity;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace ApplicationTests
{
    public class CustomersApplicationTests
    {
        private ICustomersApplication? _service;

        [Fact]
        public void CreateCustomers()
        {
            //Assert
            var model = new Customers
            {
                Id = Guid.NewGuid(),
                FirstName = "Friends",
                LastName = "Dog",
                Email = "friendsDog@gmail.com",
                Phone = "11977228269"
            };

            var _mockLogger = Substitute.For<ILogger<CustomersApplication>>();
            _service = new CustomersApplication(_mockLogger);

            //Act
            var response = _service.CreateCustomers(model);

            //Assert
            response.IsCompletedSuccessfully.Should().BeTrue();
            _mockLogger.Received().LogInformation("");
        }
    }
}