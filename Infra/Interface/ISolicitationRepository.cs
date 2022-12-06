using Domain.Entity;

namespace Infra.Interface
{
    public interface ISolicitationRepository
    {
        int Create(Solicitation solicitation);
    }
}