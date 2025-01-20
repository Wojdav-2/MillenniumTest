using MillenniumTest.Domain.Models;

namespace MillenniumTest.Domain.Interfaces;

public interface ICardService
{
    Task<CardDetails?> GetCardDetails(string userId, string cardNumber);
}