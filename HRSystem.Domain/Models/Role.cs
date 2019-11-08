﻿using System;
using System.Collections.Generic;

namespace HRSystem.Domain.Models
{
    public partial class Role
    {
        public Role()
        {
            Employee = new HashSet<Employee>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
