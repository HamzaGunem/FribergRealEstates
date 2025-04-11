using FribergRealEstatesAPI.Data;
using FribergRealEstatesAPI.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace FribergRealEstatesAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            //Auth: Hamza, Seed all data
            using (var scope = app.Services.CreateScope())
            {
                var apiDbContext = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
                SeedData.SeedAsync(apiDbContext).Wait();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

        }
    }
}
