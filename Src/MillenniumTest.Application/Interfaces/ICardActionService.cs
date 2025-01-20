using MillenniumTest.Domain.Enums;

namespace MillenniumTest.Application.Interfaces;

public interface ICardActionService
{
    Task<IEnumerable<string>> GetCardActions(string cardNumber, CardType cardType, CardStatus cardStatus, bool isPinSet);
}