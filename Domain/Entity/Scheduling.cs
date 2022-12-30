namespace Domain.Entity;

public class Scheduling
{
    public Scheduling(
        DateTime appointment,
        string outsideaddress,
        string entryaddress,
        string zipcodeoutsideaddress,
        string zipcodeentryaddress,
        float distance)
    {
        this.appointment = appointment;
        this.outsideaddress = outsideaddress;
        this.entryaddress = entryaddress;
        this.zipcodeoutsideaddress = zipcodeoutsideaddress;
        this.zipcodeentryaddress = zipcodeentryaddress;
        this.distance = distance;
    }

    public DateTime appointment { get; set; }
    public string outsideaddress { get; set; }
    public string entryaddress { get; set; }
    public string zipcodeoutsideaddress { get; set; }
    public string zipcodeentryaddress { get; set; }
    public float distance { get; set; }
}