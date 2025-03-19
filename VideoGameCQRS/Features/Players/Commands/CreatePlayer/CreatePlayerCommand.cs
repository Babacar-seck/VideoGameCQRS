using MediatR;
using VideoGameCQRS.Models;

namespace VideoGameCQRS.Features.Players.Command.CreatePlayer
{
    public record CreatePlayerCommand(string Name, int level) : IRequest<Player>;

}
