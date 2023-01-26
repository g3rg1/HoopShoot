using HoopShoot.DTO;

namespace HoopShoot.Services.Contracts
{
    public interface ITeamsService
    {
        Task<List<TeamDto>> GetAllTeams();
    }
}
