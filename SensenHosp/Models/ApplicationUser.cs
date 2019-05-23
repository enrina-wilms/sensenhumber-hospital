﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SensenHosp.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("UserID")]
        public int? UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual User user { get; set; }
    }
}
