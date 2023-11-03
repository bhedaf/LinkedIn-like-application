namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}