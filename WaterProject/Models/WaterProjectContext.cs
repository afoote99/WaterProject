using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace WaterProject.Models
{
    public class WaterProjectContext : DbContext
    {
        public WaterProjectContext (DbContextOptions<WaterProjectContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; } //Projects is going to be the name of the table in the database
    }
}
