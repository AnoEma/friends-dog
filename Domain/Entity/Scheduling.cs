namespace Domain.Entity
{
    public class Scheduling
    {
        public DateTime appointment { get; set; }
        public string outsideaddress { get; set; } = string.Empty;
        public string entryaddress { get; set; } = string.Empty;
        public string codezipoutsideaddress { get; set; } = string.Empty;
        public string codezipentryaddress { get; set; } = string.Empty;
        public float distance { get; set; }
    }
}