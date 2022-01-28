namespace SchooldDatabase
{
    public class SchoolDb
    {
        public Guid id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string birthDate { get; set; }
        public string religion { get; set; }

    }

    public static class StudentList
    {
        public static List<SchoolDb> Student { get; set; } = new List<SchoolDb>();
    }
}