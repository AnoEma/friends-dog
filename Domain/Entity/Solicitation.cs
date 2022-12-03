namespace Domain.Entity
{
    public class Solicitation
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Category { get; set; }
        public int Weight { get; set; }
        public int Ages { get; set; }
        public Scheduling? Scheduling { get; set; }
    }
}