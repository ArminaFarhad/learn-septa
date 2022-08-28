using Microsoft.EntityFrameworkCore;

namespace test
{
    public class SchoolContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Dev-29;Database=SchoolDb;User Id=sa;Password=aA123456;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}








