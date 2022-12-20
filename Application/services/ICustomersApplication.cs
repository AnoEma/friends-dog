using Domain.Entity;

namespace Application.services
{
    public interface ICustomersApplication
    {
        Guid CreateCustomers(Customers customers); 
    }
}