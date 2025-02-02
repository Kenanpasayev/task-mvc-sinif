using Microsoft.EntityFrameworkCore;
using WebApplication7.DAL;

namespace WebApplication7

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("default"));
            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(name:"default",pattern:"{controller=home}/{action=index}") ;


            app.Run();
        }
    }
}