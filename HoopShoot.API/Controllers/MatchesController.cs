using HoopShoot.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HoopShoot.API.Controllers
{
    [Route("api/matches")]
    [ApiController]
    public class MatchesController: Controller
    {
        private readonly IMatchesService matchesService;
        public MatchesController(IMatchesService teamsService)
        {
            this.matchesService = teamsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlaylist()
        {
            return new OkObjectResult(await this.matchesService.GetAllMatches());
        }
    }
}
