using MillenniumTest.Domain.Enums;

namespace MillenniumTest.Application.DTOs;

public record CardDetailsDTO(string CardNumber, CardType CardType, CardStatus CardStatus, bool IsPinSet);