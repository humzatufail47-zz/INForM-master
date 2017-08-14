using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INForM.Models
{
    public class Credentials
    {
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The Password must be at least {2} characters long.", MinimumLength = 8)]
        public String Password { get; set; }

        public String ReturnUrl { get; set; }
    }
}