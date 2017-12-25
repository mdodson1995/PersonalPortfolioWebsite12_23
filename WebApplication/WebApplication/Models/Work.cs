using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Work
    {
        public int ID { get; set; }

        [Display(Name = "Work/Internship")]

        public string WorkName { get; set; }

        [Display(Name = "Location")]

        public string WorkLocation { get; set; }

        [Display(Name = "Description of Work")]

        public string WorkDescription { get; set; }
    }
}