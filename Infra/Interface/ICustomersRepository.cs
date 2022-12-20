using Domain.Entity;

namespace Infra.Interface
{
    public interface ICustomersRepository
    {
        Guid Create(Customers customers);
    }
}