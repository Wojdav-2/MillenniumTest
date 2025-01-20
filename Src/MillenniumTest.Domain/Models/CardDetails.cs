using MillenniumTest.Domain.Enums;

namespace MillenniumTest.Domain.Models;

public record CardDetails(string CardNumber, CardType CardType, CardStatus CardStatus, bool IsPinSet);