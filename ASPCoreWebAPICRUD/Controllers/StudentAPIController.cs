using ASPCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly MyDbContext context;

        public StudentAPIController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentInfo>>> GetStudents()
        {
            var data = await context.StudentInfos.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentInfo>> GetStudent(int id)
        {
            var student = await context.StudentInfos.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);

        }

        [HttpPost]
        public async Task<ActionResult<StudentInfo>> CreateStudent(StudentInfo std)
        {
            await context.StudentInfos.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<StudentInfo>> UpdateStudent(int id , StudentInfo std)
        {
            if(id != std.Id)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentInfo>> DeleteStudent(int id)
        {
            var std = await context.StudentInfos.FindAsync(id);
            if(std == null)
            {
                return NotFound();
            }
            context.StudentInfos.Remove(std);
            await context.SaveChangesAsync();
            return Ok();
        }


    }
}
