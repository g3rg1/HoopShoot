namespace HoopShoot.DTO
{
    public class MatchDto
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public short HomeTeamScore { get; set; }
        public short AwayTeamScore { get; set; }
    }
}
