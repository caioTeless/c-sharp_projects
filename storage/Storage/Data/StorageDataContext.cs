using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    public class StorageDataContext : DbContext
    {
        public StorageDataContext(DbContextOptions<StorageDataContext> options) : base(options)
        {
        }

        public DbSet<UserModel>? UserModel { get; set; }
        public DbSet<CompanyModel>? CompanyModel { get; set; }
    }
}
