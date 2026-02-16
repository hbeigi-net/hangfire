
using MediatR;

namespace Application.Features.RouteDeliveryOptimization.Commands;
public class CreateOptimizationCommandHandler : IRequestHandler<CreateOptimizationCommand, Unit>
{
    public Task<Unit> Handle(CreateOptimizationCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Unit.Value);
    }
}