namespace SupabaseCrudApi.Models
{
    // [Table("student")]
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}