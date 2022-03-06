using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System;
using gunisKitchen.Models;

namespace gunisKitchen.Models
{

    public class MyIdentityRole
        : IdentityRole<Guid>
    {
        [StringLength(100)]
        public string Description { get; set; }

    }
}
