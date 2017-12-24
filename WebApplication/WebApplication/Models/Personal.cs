using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Personal
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone No.")]
        public string PersonalPhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string PersonalEmailAddress { get; set; }
    }
}