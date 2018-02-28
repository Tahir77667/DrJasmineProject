using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrJasmine.Models
{
    public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        //[RegularExpression("^[a-z]{3,10}$")]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Enter Your Email")]
        //[RegularExpression("^@w + ([-+.']@w+)*@@w+([-.]@w+)*@.@w+([-.]@w+)*$",ErrorMessage ="Enter Valid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Choose Your Subject")]
        //[RegularExpression("^[A-Z][a-z]{3,20}$")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Enter Proper Contact Number")]
        [RegularExpression("^[0-9]{10,10}$", ErrorMessage = "Enter a 10 Digit Number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Enter Proper Address")]
        public string Address { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }


        [Required]
        public DateTime InquiryDate { get; set; }

        [Required]
        public DateTime InquiryTime { get; set; }
    }
}