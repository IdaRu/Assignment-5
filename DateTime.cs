using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_3
{
    public class DateTypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime time = (DateTime)value;
            
            if (time < System.DateTime.Now) 
            {
                return ValidationResult.Success;
            } else 
            {
                return new ValidationResult("No time");
            }
        }
    }
}