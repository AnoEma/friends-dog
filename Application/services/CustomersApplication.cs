using Domain.Entity;
using Microsoft.Extensions.Logging;

namespace Application.services
{
    public class CustomersApplication : ICustomersApplication
    {
        private ILogger<CustomersApplication> _logger;

        public CustomersApplication(ILogger<CustomersApplication> logger)
        {
            _logger = logger;
        }

        public Task CreateCustomers(Customers customers)
        {
            try
            {
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ocorreu erro no processo {ex.Message}");
                throw;
            }
        }
    }
}