using MediatR;

namespace DShop.SharedKernel
{
    public abstract record DomainEvent : INotification;
}
