using Domain.Entity;
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

        public Dictionary<string, object> CreateSolicitation(Solicitation solicitation)
        {
            try
            {
                return new Dictionary<string, object>()
                {

                };
            }
            catch (Exception)
            {
                _logger.LogError("");
                throw;
            }
        }
    }
}