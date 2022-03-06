using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace gunisKitchen.Models
{
    public class MyIdentityUser
        : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }


    }
}
