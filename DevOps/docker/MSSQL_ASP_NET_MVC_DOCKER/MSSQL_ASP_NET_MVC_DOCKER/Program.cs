using Microsoft.EntityFrameworkCore;
using MSSQL_ASP_NET_MVC_DOCKER.AppDbContext;
using MSSQL_ASP_NET_MVC_DOCKER.Repository;

namespace MSSQL_ASP_NET_MVC_DOCKER
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            string? dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            string? dbName = Environment.GetEnvironmentVariable("DB_NAME");
            string? dbPassword = Environment
                .GetEnvironmentVariable("DB_SA_PASSWORD");
            string? connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID = sa; Password={dbPassword}";
            builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));
            builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
