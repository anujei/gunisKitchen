using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace gunisKitchen.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Qty { get; set; }
        public int Unit_Price { get; set; }
        public float Order_Bill { get; set; }
        public DateTime? Order_Date { get; set; }
        public string Address { get; set; }
        public string user_emailid { get; set; }
        public int UserId { get; set; }

       
    }
}