using BlazorDemoApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
