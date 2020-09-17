using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task_Solution.Models;

namespace Task_Solution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyTask> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasMany(u => u.TasksCreated)
                .WithOne(t => t.From)
                .HasForeignKey(t => t.FromId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(t => t.TasksTargeted)
                .WithOne(u => u.To)
                .HasForeignKey(t => t.ToId)
                .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
