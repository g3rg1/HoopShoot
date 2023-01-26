namespace HoopShoot.Models
{
    public class FullMatchInfo
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public string? HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public string? AwayTeam { get; set; }
        public short AwayTeamScore { get; set; }
        public short HomeTeamScore { get; set; }
    }
}
