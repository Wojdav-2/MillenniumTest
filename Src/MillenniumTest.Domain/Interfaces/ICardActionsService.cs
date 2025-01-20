using MillenniumTest.Domain.Models;

namespace MillenniumTest.Domain.Interfaces;

public interface ICardActionsService
{
    Task<IEnumerable<string>> GetCardActions(CardDetails cardDetails);
}