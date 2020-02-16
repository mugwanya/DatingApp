using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DatingApp.API.Controllers.Models.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> Options) : base (Options){}

        public DbSet <Value> Values { get; set; } 

    }
}