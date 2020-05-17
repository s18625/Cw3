using Cw3.DTOs.request;
using Cw3.ModelsF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw3.Services
{
    public interface IDbService
    {
        List<Student> GetStudents();
        string changeStudentData(Student s);
        string DeleteStudent(int id);

        string EnrollStudent(EnrollSudentRequest request);
        string PromoteStudent(PromoteStudentRequest p);
       

        //void CheckIndexNumber(string index);
    }
}
