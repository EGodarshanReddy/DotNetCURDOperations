using Microsoft.AspNetCore.Mvc;
using SupabaseCrudApi.Data;
using SupabaseCrudApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SupabaseCrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Students.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var student = await _context.Students.FindAsync(id);
            return student == null ? NotFound() : Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Student updatedStudent)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Email = updatedStudent.Email;

            await _context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
