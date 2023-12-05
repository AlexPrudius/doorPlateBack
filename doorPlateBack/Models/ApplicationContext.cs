using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doorPlateBack.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
