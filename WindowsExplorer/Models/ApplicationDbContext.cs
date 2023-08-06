using Microsoft.EntityFrameworkCore;

namespace WindowsExplorer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<FileInfo> FileInfo { get; set; }
        public DbSet<FolderInfo> FolderInfo { get; set; }
    }
}
