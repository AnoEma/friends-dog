namespace Domain.Entity;

public class Activity
{
    public int Id { get; set; }
    public List<Activities> Activities { get; set; } = new();
}