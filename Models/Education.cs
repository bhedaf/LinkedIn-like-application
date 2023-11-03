namespace ContosoUniversity.Models
{
    public class Education
    {
        public int ID { get; set; }
        public string UniName { get; set; }
        public string ProgName { get; set; }
        public DateTime PassingTime { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
