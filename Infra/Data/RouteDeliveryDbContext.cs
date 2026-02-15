
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class RouteDeliveryDbContext : DbContext
{

    public RouteDeliveryDbContext(DbContextOptions<RouteDeliveryDbContext> options) : base(options) { }
    public RouteDeliveryDbContext()
        : base(){}

    public  DbSet<Customer> Customers  => Set<Customer>();
    public  DbSet<Delivery> Deliveries => Set<Delivery>();
    public  DbSet<DeliverySchedule> DeliverySchedules => Set<DeliverySchedule>();
    public  DbSet<Driver> Drivers => Set<Driver>();
    public  DbSet<OptimizationRequest> OptimizationRequests => Set<OptimizationRequest>();
}