using FileUploadTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadTask.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
    }
}
