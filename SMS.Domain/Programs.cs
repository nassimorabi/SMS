﻿using System.ComponentModel.DataAnnotations;

namespace SMS.Domain
{
    public class Programs
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string? Description { get; set; }

    }
}
