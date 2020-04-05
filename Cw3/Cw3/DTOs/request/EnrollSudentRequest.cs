﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.DTOs.request
{
    public class EnrollSudentRequest
    {

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required] 
        public string IndexNumber { get; set; }
        [Required] 
        public string Birthdate { get; set; }
        [Required] 
        public string Studies { get; set; }
    }
}
