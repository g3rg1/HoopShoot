using HoopShoot.DTO;

namespace HoopShoot.Services.Contracts
{
    public interface IMatchesService
    {
        Task<List<MatchDto>> GetAllMatches();
        Task<MatchDto> GetHighlightMatch();
    }
}
