using Domain.Entity;
namespace Application.services
{
    public interface ISolicitationApplication
    {
        int CreateSolicitation(Solicitation solicitation);
    }
}