using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace faskion.Models
{
    public class form
    {
        [Required(ErrorMessage ="Please enter your name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be at least 2 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Surname")]
         [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be at least 2 characters long.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

       [ Compare("Email")]
        public string EmailConfirm { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please choose one of the two options")]
        public bool? Choice { get; set; }

        [Required(ErrorMessage = "Please choose your gender from the option")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please add your comment")]
        public string Comment { get; set; }


    }
}