using Application.services;
using Domain.Entity;
using FluentAssertions;
using Infra.Interface;
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
            var id = Guid.NewGuid();
            var model = new Customers
            {
                FirstName = "Friends",
                LastName = "Dog",
                Email = "friendsDog@gmail.com",
                Phone = "11977228269"
            };

            var mockLogger = Substitute.For<ILogger<CustomersApplication>>();
            var repository = Substitute.For<ICustomersRepository>();
            repository.Create(Arg.Any<Customers>()).Returns(id);

            _service = new CustomersApplication(mockLogger, repository);

            //Act
            var response = _service.CreateCustomers(model);

            //Assert
            mockLogger.Received().LogInformation("Realização de TDD...");
            response.Should().Be(id);
        }
    }
}