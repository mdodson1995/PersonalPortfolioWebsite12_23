using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Education
    {
        public int ID { get; set; }

        [Display(Name = "School")]
        public string schoolName { get; set; }

        [Display(Name = "Location")]
        public string schoolLocation { get; set; }

        [Display(Name = "State")]
        public string schoolState { get; set; }

        [Display(Name = "Degree")]
        public string schoolDegree { get; set; }
    }
}