using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace gunisKitchen.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductPicture { get; set; }
        [NotMapped]
        public IFormFile ProductImage { get; set; }
        [ForeignKey(nameof(Products.Category))]
        public int CId { get; set; }
        public Category Category { get; set; }
    }
}