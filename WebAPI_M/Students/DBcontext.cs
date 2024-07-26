using WebAPI_M.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_M.Students
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) :base(options){ 
        }
        public DbSet<PersonModel> PersonModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonModel>().HasData(
                new PersonModel()
                {
                    personId = 1,
                    personName = "Praveen",
                    age = 21,
                    CreatedTime = DateTime.Now,
                },
                new PersonModel()
                {
                    personId = 2,
                    personName = "Sandy",
                    age = 23,
                    CreatedTime = DateTime.Now,
                },
                new PersonModel()
                {
                    personId = 3,
                    personName = "Vikram",
                    age = 22,
                    CreatedTime = DateTime.Now,
                }

                );
            //base.OnModelCreating(modelBuilder);
        }
    }

}