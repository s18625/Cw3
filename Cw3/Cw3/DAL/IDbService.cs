﻿using Cw3.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.DAL
{
    public interface IDbService
    {
        // public IEnumerable<EnrollStudenRequest> GetStudents();
        object GetStudents();
    }
}
