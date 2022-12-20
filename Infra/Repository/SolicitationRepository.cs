using Domain.Entity;
using Infra.Interface;
using Microsoft.Extensions.Logging;

namespace Infra.Repository;

public class SolicitationRepository : ISolicitationRepository
{
    private readonly ILogger<SolicitationRepository> _logger;

    public SolicitationRepository(ILogger<SolicitationRepository> logger)
    {
        _logger = logger;
    }

    public int Create(Solicitation solicitation)
    {
        throw new NotImplementedException();
    }
}