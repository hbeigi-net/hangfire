using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Data.Extensions;

public static class AddDeliveryDbContext
{
    public static void AddRouteDeliveryDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<RouteDeliveryDbContext>(options =>
            options.UseSqlServer(connectionString)
            );

    }
}