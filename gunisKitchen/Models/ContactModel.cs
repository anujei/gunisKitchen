using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace gunisKitchen.Models
{
    public class ContactModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int contactId { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [StringLength(50)]
        [EmailAddress]
        [Required(ErrorMessage = "Email Required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Subject Required")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message Required")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}