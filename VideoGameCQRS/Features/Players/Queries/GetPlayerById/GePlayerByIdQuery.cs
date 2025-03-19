using MediatR;
using VideoGameCQRS.Models;

namespace VideoGameCQRS.Features.Players.Queries.GetPlayerById
{
    public sealed record GetPlayerByIdQuery (int playerId) : IRequest<Player?>
    {
    }
}
