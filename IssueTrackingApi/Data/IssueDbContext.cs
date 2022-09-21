using IssueTrackingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTrackingApi.Data
{
    public class IssueDbContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options) {}
    }
}
