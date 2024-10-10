using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection servicesCollectin)
    {
        // после INoteR and NoteR
        servicesCollectin.AddScoped<INoteRepository, NoteRepository>();


        servicesCollectin.AddDbContext<ApplicatianDbContext>(x =>
        {
            x.UseNpgsql("Host=localhost;Database=Notes;Username=sergey;Password=1618");
        });
        return servicesCollectin;
    }
}
