using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.modele
{
    public class EnrollStudenRequest
    {
        //public int IdStudent { get; set; }
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate  { get; set; }
        public string Studies { get; set; }
    }
   
}
