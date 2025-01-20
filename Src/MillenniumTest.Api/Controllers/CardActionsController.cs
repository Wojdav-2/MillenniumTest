using Microsoft.AspNetCore.Mvc;
using MillenniumTest.Application.DTOs;
using MillenniumTest.Application.Interfaces;

namespace MillenniumTest.Api.Controllers;

public class CardActionsController : ControllerBase
{
    [Route("/api/v2")]
    public async Task<object> GetCardActions([FromBody] CardActionsRequestDTO? cardActionsRequestDto, [FromServices] IHostEnvironment hostEnvironment, [FromServices] ICardService cardService, [FromServices] ICardActionService cardActionService)
    {
        if (cardActionsRequestDto == null || string.IsNullOrWhiteSpace(cardActionsRequestDto.UserId) || string.IsNullOrWhiteSpace(cardActionsRequestDto.CardNumber))
        {
            return new BadRequestObjectResult(cardActionsRequestDto);
        }

        var cardDetails = await cardService.GetCardDetails(cardActionsRequestDto.UserId, cardActionsRequestDto.CardNumber);

        Console.WriteLine($"{cardDetails?.CardType}|{cardDetails?.CardStatus}|{cardDetails?.IsPinSet}|{cardDetails?.CardNumber}");

        if (cardDetails is null)
        {
            if (hostEnvironment.IsDevelopment())
            {
                throw new NullReferenceException(nameof(cardDetails));
            }
            else
            {
                return new NotFoundObjectResult(null);
            }
        }

        // var actions = await cardActionService.GetCardActions(cardDetails.CardNumber, CardType.Credit, CardStatus.Active, true);
        var actions = await cardActionService.GetCardActions(cardDetails.CardNumber, cardDetails.CardType, cardDetails.CardStatus, cardDetails.IsPinSet);

        return actions;
    }
}