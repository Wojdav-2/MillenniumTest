using System.Text.Json.Serialization;

namespace MillenniumTest.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CardType
{
    Prepaid,
    Debit,
    Credit
}