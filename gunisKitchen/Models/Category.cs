using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace gunisKitchen.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CId { get; set; }
        [Required]
        public string categoryName { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
