using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using cw3.Services;
using Cw3.modele;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [Route("api/enrollments")]
    [ApiController]

    public class EnrollmentsController : ControllerBase
    {

        IDbService _dbservice;

        public EnrollmentsController(IDbService dbservice)
        {
            _dbservice = dbservice;
        }

        //[HttpPost]
        //public IActionResult EnrollStudent(EnrollStudenRequest enrollStudent)
        //{

        //    String conStr = "Data Source=db-mssql;Initial Catalog=s18625;Integrated Security=True";
        //    using (SqlConnection con = new SqlConnection(conStr))
        //    using (SqlCommand com = new SqlCommand())
        //    {
        //        com.Connection = con;
           
        //        com.CommandText = "INSERT INTO student VALUES(@IndexNumber ,@FirstName ,@LastName ,convert(datetime,'@Birthdate',4),@Studies)";
        //        com.Parameters.AddWithValue("IndexNumber", enrollStudent.IndexNumber);
        //        com.Parameters.AddWithValue("FirstName", enrollStudent.FirstName);
        //        com.Parameters.AddWithValue("LastName", enrollStudent.LastName);
        //        com.Parameters.AddWithValue("Birthdate", enrollStudent.Birthdate);
        //        com.Parameters.AddWithValue("Studies", enrollStudent.Studies);

        //    }
        //    return Ok();
        //}


    }
}