using ProjectBL.Model;
using System.Data.Entity;

namespace ProjectBL.Controller
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() : base("Host=localhost;Port=1234;Database=MyDatabase;User Id=postgres; Password=fokstrot2_4") { }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("public");
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<Income> Incomes { get; set; }
    }
}
