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

        public MatchesService(IHoopShootDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<MatchDto>> GetAllMatches()
        {
            var result = await this.dbContext.Set<FullMatchInfo>()
                .FromSqlRaw("EXEC spGetAllMatches").ToListAsync();

            return this.mapper.Map<List<MatchDto>>(result);
        }
    }
}
