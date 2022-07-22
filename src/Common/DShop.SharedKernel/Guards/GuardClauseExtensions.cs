using DShop.SharedKernel.Exceptions;

namespace DShop.SharedKernel.Guards
{
    public static partial class GuardClauseExtensions
    {
        private static void Error(string message)
        {
            throw new DomainException(message);
        }
    }
}
