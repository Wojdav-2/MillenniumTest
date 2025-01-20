using MillenniumTest.Application.DTOs;

namespace MillenniumTest.Application.Interfaces;

public interface ICardService
{
    Task<CardDetailsDTO?> GetCardDetails(string userId, string cardNumber);
}