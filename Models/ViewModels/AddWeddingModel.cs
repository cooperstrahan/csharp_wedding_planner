using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if((DateTime)value <= DateTime.Today)
            {
                return new ValidationResult("The wedding may not be at a previous date!.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
    public class AddWedding
    {
        [Required]
        [MinLength(2)]
        public string wedOne { get; set; }
        [Required]
        [MinLength(2)]
        public string wedTwo { get; set; }
        [Required]
        [FutureDate]
        public DateTime wedDate { get; set; }
        [Required]
        [MinLength(2)]
        public string wedAddress { get; set; }
        public int wedCreatorId { get; set; }
        public List<Plans> attendees { get; set; } = new List<Plans>();
        public AddWedding() {}
    }
}