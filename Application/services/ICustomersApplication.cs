using Domain.Entity;

namespace Application.services
{
    public interface ICustomersApplication
    {
        Task CreateCustomers(Customers customers); 
    }
}