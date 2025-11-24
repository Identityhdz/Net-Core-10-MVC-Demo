using Microsoft.EntityFrameworkCore;
using Sys_Dates.Models.Modules;

namespace Sys_Dates.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dates> Dates { get; set; }
    }
}
