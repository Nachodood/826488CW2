﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace _826488CW2.Models
{
    //Client class
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [MinLength(2), MaxLength(60)]
        public string Name { get; set; }
        //ToDo: Add data annotations
        public  DateTime Birthdate { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
