using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public String Name { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        public char Gender { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CustomDataRange]
        [DataType(DataType.Date)]
        public DateTime DateRegistered { get; set; }

        [Required]
        public string EventDays { get; set; }

        [Display(Name ="Additional Requirements")]
        [StringLength(100, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public String AdditionalReq { get; set; }
    }
}
