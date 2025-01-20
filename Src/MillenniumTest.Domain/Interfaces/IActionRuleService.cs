using MillenniumTest.Domain.Models;

namespace MillenniumTest.Domain.Interfaces;

public interface IActionRuleService
{
    Task<IEnumerable<ActionRules>> LoadActionRulesAsync();
}