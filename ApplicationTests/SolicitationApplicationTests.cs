using Application.services;
using Microsoft.Extensions.Logging;
using Moq;

namespace ApplicationTests
{
    public class SolicitationApplicationTests
    {
        private ISolicitationApplication? _service;
        private Mock<ILogger<SolicitationApplication>>? _mockLogger;

        [Fact]
        public void CreateSolicitation()
        {
            _mockLogger = new Mock<ILogger<SolicitationApplication>>();
            _service = new SolicitationApplication(_mockLogger.Object);
        }
    }
}