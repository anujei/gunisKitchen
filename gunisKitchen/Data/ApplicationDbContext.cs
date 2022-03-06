using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using gunisKitchen.Models;


namespace gunisKitchen.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyIdentityUser, MyIdentityRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Products> Product { get; set; }
        public DbSet<AdminLogin> adminLogin { get; set; }
        public DbSet<InvoiceModel> invoiceModels { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<ContactModel> contactModels { get; set; }
        public DbSet<BlogModel> blogModels { get; set; }
        public DbSet<Category> categorys { get; set; }
    }
}
