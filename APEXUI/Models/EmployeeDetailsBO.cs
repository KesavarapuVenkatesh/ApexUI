﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APEXUI.Models
{
    public class EmployeeDetailsBO
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string countryCode { get; set; }
        public string SSN { get; set; }
        public string MobileNumber { get; set; }
        public int UserId { get; set; }
    }
}