using _2Types.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Types.Data.Context
{
    public class _2TypesDbContext : DbContext
    {
        public _2TypesDbContext(DbContextOptions options) : base(options)

        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(f => !f.IsDeleted);
        }

        public DbSet<User> Users { get; set; }
    }
}