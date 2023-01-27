using AutoMapper;
using HoopShoot.Data.Contracts;
using HoopShoot.DTO;
using HoopShoot.Models;
using HoopShoot.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HoopShoot.Services
{
    public class TeamsService: ITeamsService
    {
        private readonly IHoopShootDbContext dbContext;
        private readonly IMapper mapper;
        private const int TopOffensiveTeamsCount = 5;
        private const int TopDefensiveTeamsCount = 5;
        private const string SpGetAllTeams = "spGetAllTeams";
        private const string SpGetTopBestDefensive = "spGetTopBestDefensive";
        private const string SpGetTopBestOffensive = "spGetTopBestOffensive";

        public TeamsService(IHoopShootDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<TeamDto>> GetAllTeams()
        {
            var result = await this.dbContext.Set<Team>()
                .FromSqlRaw($"EXEC {SpGetAllTeams}").ToListAsync();

            return this.mapper.Map<List<TeamDto>>(result);
        }

        public async Task<List<MatchQueryDto>> GetTopBestOffensiveTeams()
        {
            return await GetTopBestTeams(TopOffensiveTeamsCount, SpGetTopBestOffensive);
        }

        public async Task<List<MatchQueryDto>> GetTopBestDefensiveTeams()
        {
            return await GetTopBestTeams(TopDefensiveTeamsCount, SpGetTopBestDefensive);
        }

        private async Task<List<MatchQueryDto>> GetTopBestTeams(int count, string storedProcedure)
        {
            var sqlParam = $"@Count={count}";

            var result = await this.dbContext.Set<FullMatchInfoQuery>()
                .FromSqlRaw($"EXEC {storedProcedure} {sqlParam}").ToListAsync();

            return this.mapper.Map<List<MatchQueryDto>>(result);
        }
    }
}
