using Microsoft.Extensions.DependencyInjection;

namespace BussinessLogic;

public static class Extensions
{
    public static IServiceCollection AddBussinessLogic(this IServiceCollection serviceCollectin)
    {
        serviceCollectin.AddScoped<INoteService, NoteService>();

        return serviceCollectin;
    }
}
