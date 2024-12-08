using Login_Register.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_Register.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }

}