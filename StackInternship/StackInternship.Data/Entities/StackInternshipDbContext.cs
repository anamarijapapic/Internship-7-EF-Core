using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StackInternship.Data.Entities.Models;
using StackInternship.Data.Entities.Seeds;
using System.IO;
using System.Linq;

namespace StackInternship.Data.Entities
{
    public class StackInternshipDbContext : DbContext
    {
        public StackInternshipDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Upvote> Upvotes { get; set; }
        public DbSet<Downvote> Downvotes { get; set; }
        public DbSet<View> Views { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder
                .Entity<Comment>()
                .HasOne(c => c.Parent)
                .WithMany(pc => pc.Children)
                .HasForeignKey("ParentId")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<View>()
                .HasOne(v => v.User)
                .WithMany(u => u.Views)
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.NoAction);

            DatabaseSeeder.Execute(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class StackInternshipContextFactory : IDesignTimeDbContextFactory<StackInternshipDbContext>
    {
        public StackInternshipDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:StackInternship:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<StackInternshipDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new StackInternshipDbContext(options);
        }
    }
}
