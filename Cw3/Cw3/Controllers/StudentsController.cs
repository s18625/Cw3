using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.modele;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public String GetStudents(string orderBy="firstname")
        {
            //var v = HttpContext.Request.Query;
            return $"Jan, Anna, Katarzyna={orderBy}";
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if(id == 1)
            {
                return Ok("JAN");
            }else if(id == 2)
            {
                return Ok("anna");
            }
            else
            {
                return NotFound("not found");
            }
           
        }
        [HttpGet]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

    }
}