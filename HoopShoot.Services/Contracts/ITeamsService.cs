using HoopShoot.DTO;

namespace HoopShoot.Services.Contracts
{
    public interface ITeamsService
    {
        Task<List<TeamDto>> GetAllTeams();
        Task<List<MatchQueryDto>> GetTopBestOffensiveTeams();
        Task<List<MatchQueryDto>> GetTopBestDefensiveTeams();
    }
}
