namespace Domain.Entity;

public class Solicitation
{
    public Solicitation(
        string name, 
        Category categoryId, 
        int weight, 
        int ages, 
        Scheduling scheduling, 
        Guid customerId)
    {
        Name = name;
        CategoryId = categoryId;
        Weight = weight;
        Ages = ages;
        Scheduling = scheduling;
        CustomerId = customerId;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public Category CategoryId { get; set; }
    public int Weight { get; set; }
    public int Ages { get; set; }
    public Scheduling Scheduling { get; set; }
    public Guid CustomerId { get; set; }
}