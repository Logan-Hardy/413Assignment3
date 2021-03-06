﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413Assignment3.Models
{
    //Class used for adding movies
    public class MovieAddition
    {
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25, ErrorMessage = "That note is TOO long!")]
        public string Notes { get; set; }

    }
}
