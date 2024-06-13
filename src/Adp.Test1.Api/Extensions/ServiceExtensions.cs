using Adp.Test1.Core.Interfaces;
using Adp.Test1.Core.Services;

namespace Adp.Test1.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
