using AutoMapper;
using HoopShoot.Data.Contracts;
using HoopShoot.DTO;
using HoopShoot.Models;
using HoopShoot.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HoopShoot.Services
{
    public class MatchesService: IMatchesService
    {
        private readonly IHoopShootDbContext dbContext;
        private readonly IMapper mapper;
        private const int HighlightMatchCount = 1;
        private const string SpGetAllMatches = "spGetAllMatches";
        private const string SpGetHighlightMatch = "spGetHighlightMatch";

        public MatchesService(IHoopShootDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<MatchDto>> GetAllMatches()
        {
            var result = await this.dbContext.Set<FullMatchInfo>()
                .FromSqlRaw($"EXEC {SpGetAllMatches}").ToListAsync();

            return this.mapper.Map<List<MatchDto>>(result);
        }

        public async Task<MatchDto> GetHighlightMatch()
        {
            var sqlParam = $"@Count={HighlightMatchCount}";
            
            var result = await this.dbContext.Set<FullMatchInfo>()
                .FromSqlRaw($"EXEC {SpGetHighlightMatch} {sqlParam}").ToListAsync();

            return this.mapper.Map<MatchDto>(result.FirstOrDefault());
        }
    }
}
