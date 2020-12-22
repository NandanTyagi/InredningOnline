// using Microsoft.EntityFrameworkCore;

// namespace InredningOnline.Models
// {
//     public class AppDbContext : DbContext
//     {
//         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//         {
//             this.Database.EnsureCreated();
//         }

//         public DbSet<Project> Projects { get; set; }
//         public DbSet<Material> Materials { get; set; }
//         public DbSet<User> Users { get; set; }


//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             base.OnModelCreating(modelBuilder);

//             // Seed categories

//             modelBuilder.Entity<Material>().HasData(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });

//             //Seed sculptures

//             modelBuilder.Entity<Project>().HasData(new Project
//             {
//                 Name = "MyFirstProject",
//                 UserName = { Name = "Nandan", Email = "me@nandan.com" },
//                 Materials = {new Material{Name = "Chair", Price = 10, Amount = 2, Details = "N/A" }}
                
//             });

//             modelBuilder.Entity<Sculpture>().HasData(new Sculpture
//             {
//                 Id = 2,
//                 Name = "Sphearish",
//                 Price = 10000000000,
//                 CategoryId = 4,
//                 Description = "Mysterious and amazing metal sphearish thing.",
//                 ThumbNail = "/images/sphear_thumbnail.jpg",
//                 Image = "/images/sphear.jpg"
//             });

//         }
//     }
// }