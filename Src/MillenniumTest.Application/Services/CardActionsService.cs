using MillenniumTest.Application.Interfaces;
using MillenniumTest.Domain.Enums;
using MillenniumTest.Domain.Models;

namespace MillenniumTest.Application.Services;

public class CardActionsService(Domain.Interfaces.ICardActionsService cardActionsService) : ICardActionService
{
    public async Task<IEnumerable<string>> GetCardActions(string cardNumber, CardType cardType, CardStatus cardStatus, bool isPinSet)
    {
        var cardDetails = new CardDetails(cardNumber, cardType, cardStatus, isPinSet);
        var actionRules = await cardActionsService.GetCardActions(cardDetails);
        return actionRules;
    }
}