using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddDbContext<ToDoAppContext>(x =>
            {
                x.UseNpgsql(connectionString);
            });
            return services;
        }
    }
}
