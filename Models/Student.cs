using System.ComponentModel.DataAnnotations.Schema;

namespace SupabaseCrudApi.Models
{
    [Table("student")] // Uncommented this line
    public class Student
    {
        // EF Core will typically infer 'Id' as the primary key.
        // If it were a different name (e.g., StudentId), you might need [Key] attribute.
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}