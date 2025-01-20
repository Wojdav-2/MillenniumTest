using Microsoft.Extensions.DependencyInjection;
using MillenniumTest.Application.Services;
using CardActionsService = MillenniumTest.Application.Services.CardActionsService;
using ICardActionService = MillenniumTest.Application.Interfaces.ICardActionService;
using ICardService = MillenniumTest.Application.Interfaces.ICardService;

namespace MillenniumTest.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICardService, CardService>();
        serviceCollection.AddSingleton<ICardActionService, CardActionsService>();

        return serviceCollection;
    }
}