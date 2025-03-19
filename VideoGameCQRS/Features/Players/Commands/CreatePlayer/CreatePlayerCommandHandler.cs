using MediatR;
using VideoGameCQRS.Data;
using VideoGameCQRS.Models;

namespace VideoGameCQRS.Features.Players.Command.CreatePlayer
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Player>
    {
        private readonly VideoGameAppDbContext _context;

        public CreatePlayerCommandHandler(VideoGameAppDbContext context)
        {
            _context = context;
        }

        public async Task<Player> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = new Player { Name = request.Name, Level = request.level };

            _context.Players.Add(player);

            await _context.SaveChangesAsync();

            return player;
        }
    }
}
