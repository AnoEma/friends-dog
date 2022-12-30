namespace Domain.Entity;

public class Scheduling
{
    public DateTime appointment { get; set; }
    public string outsideaddress { get; set; }
    public string entryaddress { get; set; }
    public string zipcodeoutsideaddress { get; set; }
    public string zipcodeentryaddress { get; set; }
    public float distance { get; set; }
}