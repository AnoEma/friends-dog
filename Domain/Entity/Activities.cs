namespace Domain.Entity;

public class Activities
{
    public Activities(
        string name,
        string description,
        Types types,
        DateTime started,
        DateTime lastUpdated,
        bool active)
    {
        Name = name;
        Description = description;
        Types = types;
        Started = started;
        LastUpdated = lastUpdated;
        Active = active;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Types Types { get; set; }
    public DateTime Started { get; set; }
    public DateTime LastUpdated { get; set; }
    public bool Active { get; set; }
}