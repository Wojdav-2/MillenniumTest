using System.Text.Json;
using MillenniumTest.Domain.Interfaces;
using MillenniumTest.Domain.Models;

namespace MillenniumTest.Infrastructure.ActionRule;

public class ActionRuleService : IActionRuleService
{
    public async Task<IEnumerable<ActionRules>> LoadActionRulesAsync()
    {
        var path = Path.Combine(AppContext.BaseDirectory + @"ActionRule\ActionRules.json");
        var json = await LoadJsonFile(path);
        var actionRules = ParseJson(json);
        return actionRules;
    }

    private async Task<string> LoadJsonFile(string path)
    {
        try
        {
            var s = await File.ReadAllTextAsync(path);
            return s;
        }
        catch (Exception exception)
        {
            throw new Exception("File loading threw exception.", exception);
        }
    }

    private IEnumerable<ActionRules> ParseJson(string json)
    {
        try
        {
            var r = JsonSerializer.Deserialize<List<ActionRules>>(json) ?? throw new NullReferenceException("Serializer returned null.");
            return r;
        }
        catch (Exception exception)
        {
            throw new Exception("Json parsing exception.", exception);
        }
    }
}