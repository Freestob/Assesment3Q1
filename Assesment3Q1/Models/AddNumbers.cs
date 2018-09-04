using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assesment3Q1.Models
{
    public class AddNumbers
    {
        [Required]
        [Range(1, 1000)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public int NumberOne { get; set; }

        [Required]
        [Range(1, 1000)]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Count must be a natural number")]
        public int NumberTwo { get; set; }

    }
}