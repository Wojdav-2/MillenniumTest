using MillenniumTest.Application.Extensions;
using MillenniumTest.Infrastructure.Extensions;

namespace MillenniumTest.Api;

public class Program
{
    public static async Task Main(string[] argumentList)
    {
        var builder = WebApplication.CreateBuilder(argumentList);

        builder.Services.AddApplicationServices();
        builder.Services.AddInfrastructure();
        builder.Services.AddControllers();

        var webApplication = builder.Build();

        webApplication.UseHttpsRedirection();
        webApplication.MapControllers();

        await webApplication.RunAsync();
    }
}