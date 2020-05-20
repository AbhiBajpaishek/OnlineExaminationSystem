using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) :
                                                    base(options)
        {
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(
                new Course{Id=1,Name="BCA"},
                new Course{Id=2,Name="BCOM"}
            );
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ExaminationCenter> ExaminationCenters { get; set; }    
        public DbSet<User> Users { get; set; }
    }
}