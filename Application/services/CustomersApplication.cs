using Domain.Entity;
using Infra.Interface;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks.Sources;

namespace Application.services
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly ILogger<CustomersApplication> _logger;
        private readonly ICustomersRepository _customersRepository;

        public CustomersApplication(ILogger<CustomersApplication> logger, ICustomersRepository customersRepository)
        {
            _logger = logger;
            _customersRepository = customersRepository;
        }

        public Guid CreateCustomers(Customers customers)
        {
            try
            {
                if (customers == null)
                {
                    throw new InvalidOperationException();
                }
                _logger.LogInformation("Realização de TDD...");

                return _customersRepository.Create(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ocorreu erro no processo {ex.Message}");
                throw;
            }
        }
    }
}