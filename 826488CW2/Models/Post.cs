﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _826488CW2.Models
{
    public class Post
{
    [Key]
    public int Id { get; set; }
    public string Content { get; set; }
}
}
