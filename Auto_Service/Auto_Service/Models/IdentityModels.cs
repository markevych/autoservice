﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Auto_Service.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name"), Required]
        public string FullName { get; set; }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class ServiceContext : DbContext
    {
        public ServiceContext() : base("DefaultConnection") { }
        public static ServiceContext Create()
        {
            return new ServiceContext();
        }
        public DbSet<Service> Services { get; set; }
    }

    public class OrdersContext : DbContext
    {
        public OrdersContext() : base("DefaultConnection") { }
        public static OrdersContext Create()
        {
            return new OrdersContext();
        }
        public DbSet<Order> Orders { get; set; }
    }
}