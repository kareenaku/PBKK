using Microsoft.EntityFrameworkCore;
using Razor.Models;

namespace Razor.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
