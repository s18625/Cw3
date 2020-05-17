using Cw3.DTOs.request;
using Cw3.ModelsF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cw3.Services
{
    public class SqlServerDbService : IDbService
    {

        public string changeStudentData(Student stChange)
        {
            var db = new s18625Context();
            Student st = db.Student.First(s => s.IndexNumber == s.IndexNumber);

            if (st == null) return "blad";

            st.LastName = stChange.LastName;
            st.IdEnrollment = stChange.IdEnrollment;
            st.FirstName = stChange.FirstName;
            st.BirthDate = stChange.BirthDate;
            st.BirthDate = stChange.BirthDate;
            db.SaveChanges();

            return "Ok";



        }

        //public void CheckIndexNumber(string index)
        //{
        //    throw new NotImplementedException();
        //}
        

        public string DeleteStudent(int id)
        {
            var db = new s18625Context();
            try
            {
                var stDelete = db.Student.First(s => Int32.Parse(s.IndexNumber) == id);

                if (stDelete == null) return "blad";
                
                    db.Student.Remove(stDelete);
                    db.SaveChanges();
                
            }
            catch (SqlException exc)
            {
                return "blad";
            }
            return "Ok";
            
        }

        public string EnrollStudent(EnrollSudentRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            var db = new s18625Context();

            return db.Student.ToList();
        }

        public string PromoteStudent(PromoteStudentRequest req)
        {
            var db = new s18625Context();


            try
            {
                var id = db.Studies.First(s => s.Name == req.Studies).IdStudy;
                var idE = db.Enrollment.Where(e => e.IdStudy == id)
                    .Where(e => e.Semester == req.Semester);


                if (idE.Count() < 1)
                    return "error";


                
                foreach (var en in idE)
                {

                    en.Semester += 1;

                }


                db.SaveChanges();
                return ("Ok");

            }
            catch (SqlException exc)
            {

                return "error";

            }
            
        }
    }
}
