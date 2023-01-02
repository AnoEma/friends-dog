using Application.services;
using Infra.Interface;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace ApplicationTests
{
    public class SolicitationApplicationTests
    {
        private ISolicitationApplication? _service;

        [Fact]
        public void CreateSolicitation()
        {
            var _mockLogger = Substitute.For<ILogger<SolicitationApplication>>();
            var _repository = Substitute.For<ISolicitationRepository>();
            _service = new SolicitationApplication(_mockLogger, _repository);
        }
    }
}