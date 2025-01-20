using MillenniumTest.Domain.Interfaces;
using MillenniumTest.Domain.Models;

namespace MillenniumTest.Domain.Services;

public class CardActionsService(IActionRuleService actionRuleService) : ICardActionsService
{
    public async Task<IEnumerable<string>> GetCardActions(CardDetails cardDetails)
    {
        var actionRules = await actionRuleService.LoadActionRulesAsync();

        var result = actionRules
            .Where(x => x.CardTypes.Contains(cardDetails.CardType)
                        && (
                            (x.RequiresPIN.Count == 0 && x.PINNotAllowed.Count == 0 && x.CardStatuses.Contains(cardDetails.CardStatus))
                            || (x.RequiresPIN.Count != 0 && x.RequiresPIN.Contains(cardDetails.CardStatus) && cardDetails.IsPinSet)
                            || (x.PINNotAllowed.Count != 0 && x.PINNotAllowed.Contains(cardDetails.CardStatus) && !cardDetails.IsPinSet)
                        ))
            .Select(x => x.ActionName);

        return result;
    }
}