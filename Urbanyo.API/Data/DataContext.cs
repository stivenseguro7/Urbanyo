using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Urbanyo.Shared.Entities;

namespace Urbanyo.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<StateProject>StateProjects { get; set; }  
        public  DbSet<QuestionConstruction> QuestionConstructions { get; set; } 
        public DbSet<QuestionLegalization>QuestionLegalizations { get; set; }
        public DbSet<QuestionReshuffle>QuestionReshuffles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("CountryId", "Name").IsUnique();
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
            modelBuilder.Entity<Project>().HasIndex("ProjectTypeId", "UserId","StateId","CityId").IsUnique();   
            modelBuilder.Entity<StateProject>().HasIndex(x => x.ProjectTypeId).IsUnique();
            modelBuilder.Entity<QuestionConstruction>().HasIndex(x => x.ProjectTypeId).IsUnique();
            modelBuilder.Entity<QuestionLegalization>().HasIndex(x => x.ProjectTypeId).IsUnique();
            modelBuilder.Entity<QuestionReshuffle>().HasIndex(x => x.ProjectTypeId).IsUnique();

        }
    }
}
