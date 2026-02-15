using Presentation.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);


#region DevliveryDbContext
var connectionString = builder.Configuration.GetConnectionString("RouteDelivery");
builder.Services.AddRouteDeliveryDbContext(connectionString!);
#endregion

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();
