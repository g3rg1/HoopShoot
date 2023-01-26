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

        public TeamsService(IHoopShootDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<TeamDto>> GetAllTeams()
        {
            var result = await this.dbContext.Set<Team>()
                .FromSqlRaw("EXEC spGetAllTeams").ToListAsync();

            return this.mapper.Map<List<TeamDto>>(result);
        }
    }
}
