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
        public async Task<IActionResult> GetPlaylist()
        {
            return new OkObjectResult(await this.teamsService.GetAllTeams());
        }
    }
}
