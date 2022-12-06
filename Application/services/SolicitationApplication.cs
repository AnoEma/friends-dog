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

        public int CreateSolicitation(Solicitation solicitation)
        {
            try
            {
                if(solicitation == null)
                {
                    throw new ArgumentNullException(nameof(solicitation));
                }

                return 0;
            }
            catch (Exception)
            {
                _logger.LogError("[SolicitationApplication CreateSolicitation] Ocorrei erro ao agendar a solicitação");
                throw;
            }
        }
    }
}