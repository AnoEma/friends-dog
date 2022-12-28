using Domain.Entity;
using Infra.Interface;

namespace Infra.Repository;

public class CustomersRepository : ICustomersRepository
{

    public Guid Create(Customers customers)
    {
        customers.Id = Guid.NewGuid();
        return customers.Id;
    }
}