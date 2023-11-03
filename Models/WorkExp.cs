namespace ContosoUniversity.Models
{
    public class WorkExp
    {
        public int ID { get; set; }

        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
