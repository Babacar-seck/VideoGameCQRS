using MediatR;
using VideoGameCQRS.Data;
using VideoGameCQRS.Models;

namespace VideoGameCQRS.Features.Players.Queries.GetPlayerById
{
    public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, Player?>
    {
        private readonly VideoGameAppDbContext _context;

        public GetPlayerByIdQueryHandler(VideoGameAppDbContext context)
        {
            _context = context;
        }
        public async Task<Player?> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            var player = await _context.Players.FindAsync(request.playerId);

            return player;
        }
    }
}
