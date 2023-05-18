using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.WebRequestMethods;

namespace SchoolApi.Models
{
    public class SchoolDbContext : DbContext
    {

        public SchoolDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<School> Schools { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                new School
                {
                    Id = 1,
                    Name = "Eniso",
                    Sections = "IA,EI,GTE",
                    Director = "Director1",
                    Rating = 3.5,
                    WebSite = "http://www.eniso.rnu.tn"
                },
                new School
                {
                    Id = 2,
                    Name = "Enim",
                    Sections = "MECA,ENERG,TEXT",
                    Director = "Director2",
                    Rating = 3.0,
                    WebSite = "https://enim.rnu.tn/"
                },
                new School
                {
                    Id = 3,
                    Name = "School3",
                    Sections = "Sec1,Sec2,Sec3",
                    Director = "Director3",
                    Rating = 3.0,
                    WebSite = ""
                }

                );


        }


    }
}

