using Microsoft.Extensions.DependencyInjection;
using MillenniumTest.Domain.Interfaces;
using MillenniumTest.Domain.Services;
using MillenniumTest.Infrastructure.ActionRule;
using MillenniumTest.Infrastructure.Card;

namespace MillenniumTest.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IActionRuleService, ActionRuleService>();
        serviceCollection.AddSingleton<ICardService, CardService>();
        serviceCollection.AddSingleton<ICardActionsService, CardActionsService>();

        return serviceCollection;
    }
}