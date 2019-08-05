﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model {
    public class Tag {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
