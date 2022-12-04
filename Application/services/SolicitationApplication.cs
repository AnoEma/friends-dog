using Microsoft.Extensions.Logging;

namespace Application.services
{
    public class SolicitationApplication : ISolicitationApplication
    {
        private readonly ILogger<SolicitationApplication> _logger;

        public SolicitationApplication(ILogger<SolicitationApplication> logger)
        {
            _logger = logger;
        }
    }
}