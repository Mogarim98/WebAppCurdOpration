using Microsoft.EntityFrameworkCore;
using WebAppCurdOpration.Models;

namespace WebAppCurdOpration.Data
{
    public class AppliceionDbContext :DbContext
    {
        public AppliceionDbContext(DbContextOptions<AppliceionDbContext> options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          //  modelBuilder.Entity<Employee>().ToTable("Employees", "HR");
        }
        public DbSet<Departmen> Departmens { get; set; }  
       public DbSet<Employee> Employees { get; set; }

    }
}
