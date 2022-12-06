namespace Domain.Entity
{
    public class Customers
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int SolicitationId { get; set; }
    }
}