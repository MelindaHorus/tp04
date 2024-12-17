﻿using Microsoft.EntityFrameworkCore;
using web04.Models;
using WebApiCRUD.Models;

namespace web04.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
