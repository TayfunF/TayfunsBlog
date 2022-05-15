﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunsBlog.Core.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; } = true;
    }
}
