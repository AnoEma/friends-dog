namespace Domain.Entity
{
    public class Scheduling
    {
        public DateTime appointment { get; set; }
        public string outsideaddress { get; set; } = string.Empty;
        public string entryaddress { get; set; } = string.Empty;
        public string zipcodeoutsideaddress { get; set; } = string.Empty;
        public string zipcodeentryaddress { get; set; } = string.Empty;
        public float distance { get; set; }
    }
}