﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee:BaseEntity
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public decimal Salary { get; set; }
    }
}

