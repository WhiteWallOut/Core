﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreForStudent.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
    }
}
