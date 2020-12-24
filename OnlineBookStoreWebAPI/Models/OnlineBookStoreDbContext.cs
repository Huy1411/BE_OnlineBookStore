using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreWebAPI.Models
{
    public class OnlineBookStoreDbContext:DbContext
    {
        public OnlineBookStoreDbContext(DbContextOptions<OnlineBookStoreDbContext> options) : base(options)
        {

        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorProducts> AuthorProducts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublisherProducts> PublisherProducts { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
