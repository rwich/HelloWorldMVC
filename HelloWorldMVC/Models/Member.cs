using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldMVC.Models
{
    public class Member
    {
        public string Email { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Email Address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}