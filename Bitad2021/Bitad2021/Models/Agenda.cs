﻿using System;

namespace Bitad2021.Models
{
    public class Agenda
    {
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Speaker Speaker { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
    }
}