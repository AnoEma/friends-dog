using Application.services;
using Domain.Entity;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;

namespace ApplicationTests
{
    public class CustomersApplicationTests
    {
        private ICustomersApplication? _service;
        private Mock<ILogger<CustomersApplication>>? _mockLogger;

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
            _mockLogger = new Mock<ILogger<CustomersApplication>>();
            _service = new CustomersApplication(_mockLogger.Object);

            //Act
            var response = _service.CreateCustomers(model);

            //Assert
            response.IsCompletedSuccessfully.Should().BeTrue();
        }
    }
}