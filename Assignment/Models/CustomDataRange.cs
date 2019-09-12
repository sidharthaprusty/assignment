using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class CustomDataRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date =(DateTime)value;
            if(date>= new DateTime(2019,01,01) && date<= new DateTime(2019, 06, 30))
                return ValidationResult.Success;

            return new ValidationResult("Date must be between 01/01/2019 to 30/06/2019");
        }
    }
}
