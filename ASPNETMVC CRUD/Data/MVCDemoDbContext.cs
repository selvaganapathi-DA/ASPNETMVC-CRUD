using ASPNETMVC_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace ASPNETMVC_CRUD.Data
{
    public class MVCDemoDbContext:DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        }

}
