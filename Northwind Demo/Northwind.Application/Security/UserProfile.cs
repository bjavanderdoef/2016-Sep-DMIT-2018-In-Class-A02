﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Security
{
    public class UserProfile
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int? EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> RoleMemberships { get; set; }
    }
}
