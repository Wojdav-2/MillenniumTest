using MillenniumTest.Domain.Enums;

namespace MillenniumTest.Domain.Models;

public class ActionRules
{
    public string ActionName { get; set; }
    public List<CardType> CardTypes { get; set; }
    public List<CardStatus> CardStatuses { get; set; }
    public List<CardStatus> RequiresPIN { get; set; }
    public List<CardStatus> PINNotAllowed { get; set; }
}