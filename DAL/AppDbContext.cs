using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 


        }
        public DbSet<Slider>Sliders { get; set; }
    }
}
