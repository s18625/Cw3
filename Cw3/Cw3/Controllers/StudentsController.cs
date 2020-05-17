using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cw3.Services;
using Cw3.modele;
using Cw3.ModelsF;
using Cw3.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            //var v = HttpContext.Request.Query;
            //return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";

            /*  var list = new List<EnrollStudenRequest>();
              string id = "Jan";
              String conStr = "Data Source=db-mssql;Initial Catalog=s18625;Integrated Security=True";
              using (SqlConnection con = new SqlConnection(conStr))
              using (SqlCommand com = new SqlCommand())
              {
                  com.Connection = con;
                  //com.CommandText = "Drop Table Student";
                  com.CommandText = "Select * from Student where FirstName=@id";
                  com.Parameters.AddWithValue("id",id);

                  con.Open();
                  var dataReader = com.ExecuteReader();
                  while (dataReader.Read())
                  {
                      var st = new EnrollStudenRequest();
                      st.IndexNumber = dataReader["IndexNumber"].ToString();
                      st.FirstName = dataReader["FirstName"].ToString();
                      st.LastName = dataReader["LastName"].ToString();
                      list.Add(st);
                  }


              }*/


            //return Ok(_dbService.GetStudents());
            return Ok(_dbService.GetStudents());
        }
        [HttpPost]
        public IActionResult ChangeStudnet(Student st)
        {
            var str = _dbService.changeStudentData(st);
            if (str.Equals("blad")) return BadRequest();
            return Ok("change completed");
        }
        [HttpPost("{id}")]
        public IActionResult DeleteStudent([FromRoute]int id)
        {
            var s = _dbService.DeleteStudent(id);
            if (s == "blad") return BadRequest();
            return Ok("Student deleted");

        }

        //[HttpGet("{id}")]
        //public IActionResult GetStudent(String id)

        //{
        //    var list = new List<Enrollment>();
        //    String conStr = "Data Source=db-mssql;Initial Catalog=s18625;Integrated Security=True";
        //    using (SqlConnection con = new SqlConnection(conStr))
        //    using (SqlCommand com = new SqlCommand())
        //    {
        //        com.Connection = con;
        //        com.CommandText = "Select * from enrollment e inner join student s on e.IdEnrollment =s.IdEnrollment   where s.indexNumber ="+id;

        //        con.Open();
        //        var dataReader = com.ExecuteReader();
        //        while (dataReader.Read())
        //        {

        //            Enrollment st = new Enrollment();
        //            st.IdEnrollment = Int32.Parse(dataReader["IdEnrollment"].ToString());
        //            st.Semester = Int32.Parse(dataReader["semester"].ToString());
        //            st.IdStudy = Int32.Parse(dataReader["idstudy"].ToString());
        //            st.StartDate = dataReader["StartDate"].ToString();
        //            list.Add(st);
        //        }
              


        //    }
        //    return Ok(list);


        //}
        //[HttpPost]
        //public IActionResult CreateStudent(EnrollStudenRequest student)
        //{
        //    student.IndexNumber = $"s{new Random().Next(1, 20000)}";
        //    return Ok(student);
        //}
        //[HttpPut("{id}")]
        //public IActionResult PutStudent(int id)
        //{
        //    return Ok("aktualizacja ukonczona "+id);
        //}
        //[HttpDelete("{id}")]
        //public IActionResult DeleteStudent(int id)
        //{
        //    return Ok("Usuwanie ukonczone " + id);
        //}

    }
}