using AutoMapper;
using HoopShoot.DTO;
using HoopShoot.Models;

namespace HoopShoot.Services.MappingProfiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Team, TeamDto>();

            CreateMap<Match, MatchDto>();
        }
    }
}
