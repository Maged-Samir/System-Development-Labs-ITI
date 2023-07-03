using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITI.Revision.WebAPI.Data;
using ITI.Revision.WebAPI.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using ITI.Revision.WebAPI.DTO.Course;
using Microsoft.AspNetCore.Authorization;

namespace ITI.Revision.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Course
        [HttpGet]
        [Authorize(Policy = "AllowManagers")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
          if (_context.Courses == null)
          {
              return NotFound();
          }

            //return await _context.Courses.ToListAsync();
            return await _context.Courses.Include(s=>s.Students).ToListAsync();
        }

        // GET: api/Course/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
          if (_context.Courses == null)
          {
              return NotFound();
          }
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        // PUT: api/Course/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, [FromBody] CourseUpdateDTO courseDTO)
        {
            var course = _context.Courses.Find(id);

            if (course == null)
            {
                return NotFound();
            }

            course.Name = courseDTO.Name;
            course.Description = courseDTO.Description;
            course.Level = courseDTO.Level;

            _context.Update(course);
            _context.SaveChanges();

            return Ok(course);
            
        }

        // POST: api/Course
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse([FromBody] CourseCreateDTO courseDTO)
        {
          if (_context.Courses == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Courses'  is null.");
          }

          //to solve the problem of navigation properity
            var course = new Course
            {
                Name = courseDTO.Name,
                Description = courseDTO.Description,
                Level = courseDTO.Level
            };

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Course/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return (_context.Courses?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost("{courseId}/students")]
        public IActionResult AssignStudentsToCourse(int courseId, [FromBody] List<int> studentIds)
        {

            var course = _context.Courses.Include(c => c.Students).FirstOrDefault(c => c.Id == courseId);

            if (course == null)
            {
                return NotFound();
            }

            var students = _context.Students.Where(s => studentIds.Contains(s.Id)).ToList();

            foreach (var student in students)
            {
                if (!course.Students.Contains(student))
                {
                    course.Students.Add(student);
                }
            }

            _context.SaveChanges();
            return Ok();
        }


    }
}
