using Domain.Entity;
using Infra.Interface;
using Microsoft.Extensions.Logging;

namespace Application.services
{
    public class SolicitationApplication : ISolicitationApplication
    {
        private readonly ILogger<SolicitationApplication> _logger;
        private readonly ISolicitationRepository _repository;

        public SolicitationApplication(
            ILogger<SolicitationApplication> logger, 
            ISolicitationRepository repository
            )
        {
            _logger = logger;
            _repository = repository;
        }

        public int CreateSolicitation(Solicitation solicitation)
        {
            try
            {
                if(solicitation is null)
                {
                    throw new ArgumentNullException(nameof(solicitation));
                }

                return _repository.Create(solicitation);
            }
            catch (Exception)
            {
                _logger.LogError("[SolicitationApplication CreateSolicitation] Ocorrei erro ao agendar a solicitação");
                throw;
            }
        }
    }
}