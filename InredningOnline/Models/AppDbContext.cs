using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InredningOnline.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Designers
            modelBuilder.Entity<Designer>().HasData(new Designer { Id = 1, Name = "Nandan", Email = "me@nandan.com", IsAdmin = true });
            modelBuilder.Entity<Designer>().HasData(new Designer { Id = 2, Name = "Hadis", Email = "me@hadis.com", IsAdmin = false });
            modelBuilder.Entity<Designer>().HasData(new Designer { Id = 3, Name = "Ali", Email = "me@ali.com", IsAdmin = false });


            // Seed Projects
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 1,
                Name = "Project1",
                DesignerId = 1,
                // Materials = (System.Collections.Generic.IEnumerable<Material>)modelBuilder.Entity<Material>().HasData(new Material { ProjectId = 1, Name = "Material1", Price = 25, Amount = 1, Details = "N/A" })
            });
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 2,
                Name = "Project2",
                DesignerId = 2,
                // Materials = (System.Collections.Generic.IEnumerable<Material>)modelBuilder.Entity<Material>().HasData(new Material { ProjectId = 1, Name = "Material1", Price = 25, Amount = 1, Details = "N/A" })
            });
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 3,
                Name = "Project3",
                DesignerId = 3,
                // Materials = (System.Collections.Generic.IEnumerable<Material>)modelBuilder.Entity<Material>().HasData(new Material { ProjectId = 1, Name = "Material1", Price = 25, Amount = 1, Details = "N/A" })
            });
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 4,
                Name = "Project4",
                DesignerId = 2,
                // Materials = (System.Collections.Generic.IEnumerable<Material>)modelBuilder.Entity<Material>().HasData(new Material { ProjectId = 1, Name = "Material1", Price = 25, Amount = 1, Details = "N/A" })
            });

            // Seed Materials
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 1,
                ProjectId = 1,
                Name = "Material1",
                Supplier = "Supplier1",
                Price = 45,
                Amount = 1,
                Details = "N/A"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 2,
                ProjectId = 2,
                Name = "Material2",
                Supplier = "Supplier2",
                Price = 98,
                Amount = 1,
                Details = "N/A"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 3,
                ProjectId = 4,
                Name = "Material3",
                Supplier = "Supplier3",
                Price = 67000,
                Amount = 1,
                Details = "N/A"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 4,
                ProjectId = 3,
                Name = "Material4",
                Supplier = "Supplier4",
                Price = 77,
                Amount = 2,
                Details = "N/A"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 5,
                ProjectId = 2,
                Name = "Material5",
                Supplier = "Supplier5",
                Price = 105,
                Amount = 10,
                Details = "N/A"
            });
            modelBuilder.Entity<Material>().HasData(new Material
            {
                Id = 6,
                ProjectId = 2,
                Name = "Material6",
                Supplier = "Supplier6",
                Price = 12,
                Amount = 1,
                Details = "N/A"
            });
        }
    }
}

