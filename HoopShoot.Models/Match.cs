namespace HoopShoot.Models
{
    public class Match: EntityBase
    {
        public int? HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public int? AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}
