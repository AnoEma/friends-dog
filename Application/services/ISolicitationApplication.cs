using Domain.Entity;
namespace Application.services
{
    public interface ISolicitationApplication
    {
        Dictionary<string, object> CreateSolicitation(Solicitation solicitation);
    }
}