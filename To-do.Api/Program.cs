using DAL;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;

namespace To_do.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            //string connectionString = builder.Configuration.GetConnectionString("DockerConnection")!;
            builder.Services.AddDataAccess(connectionString);
            builder.Services.AddNoteService();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ToDoAppContext>();
                dbContext.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                {
                    context.Response.Redirect("/swagger/index.html");
                    return;
                }
                await next();
            });

            app.MapControllers();

            app.Run();
        }
    }
}
