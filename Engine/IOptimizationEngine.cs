using Domain.Entities;

namespace Engine;
public interface IOptimizationEngine
{
    List<DeliverySchedule> OptimizeDeliveries(int requestID);
}
