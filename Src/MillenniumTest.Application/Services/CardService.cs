using MillenniumTest.Application.DTOs;
using MillenniumTest.Application.Interfaces;

namespace MillenniumTest.Application.Services;

public class CardService(Domain.Interfaces.ICardService cardService) : ICardService
{
    public async Task<CardDetailsDTO?> GetCardDetails(string userId, string cardNumber)
    {
        var cardDetails = await cardService.GetCardDetails(userId, cardNumber);

        if (cardDetails is null)
        {
            return null;
        }

        var r = new CardDetailsDTO(cardDetails.CardNumber, cardDetails.CardType, cardDetails.CardStatus, cardDetails.IsPinSet);

        return r;
    }
}