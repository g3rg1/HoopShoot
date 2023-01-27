using HoopShoot.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HoopShoot.API.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController: Controller
    {
        private readonly ITeamsService teamsService;
        public TeamsController(ITeamsService teamsService)
        {
            this.teamsService = teamsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            return new OkObjectResult(await this.teamsService.GetAllTeams());
        }

        [HttpGet]
        [Route("topDefensive")]
        public async Task<IActionResult> GetTopBestDefensiveTeams()
        {
            return new OkObjectResult(await this.teamsService.GetTopBestDefensiveTeams());
        }

        [HttpGet]
        [Route("topOffensive")]
        public async Task<IActionResult> GetTopBestOffensiveTeams()
        {
            return new OkObjectResult(await this.teamsService.GetTopBestOffensiveTeams());
        }
    }
}
