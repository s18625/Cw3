using Cw3.DTOs.request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.service
{
    interface IStudentDbService
    {
        string EnrollStudent(EnrollSudentRequest enroll);
       // string PromoteStudents(PromoteStudentRequest promote);
    }
}
