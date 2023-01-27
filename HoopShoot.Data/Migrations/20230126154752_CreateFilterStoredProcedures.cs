using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoopShoot.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateFilterStoredProcedures : Migration
    {
        private const string GetHighlightMatchStoredProcedureName = "spGetHighlightMatch";
        private const string GetTopBestOffensiveStoredProcedureName = "spGetTopBestOffensive";
        private const string GetTopBestDefensiveStoredProcedureName = "spGetTopBestDefensive";
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var getHighlightMatchStoredProcedure = $@"CREATE OR ALTER PROCEDURE {GetHighlightMatchStoredProcedureName} @Count int
                                                AS
                                                SELECT TOP (@Count)
                                                Matches.Id,
                                                Matches.HomeTeamId,
                                                Home.Name AS HomeTeam,
                                                Matches.AwayTeamId,
                                                Away.Name AS AwayTeam,
                                                Matches.AwayTeamScore,
                                                Matches.HomeTeamScore 
                                                FROM Matches
                                                JOIN Teams AS Home 
                                                	ON Home.Id=Matches.HomeTeamId
                                                JOIN Teams AS Away
                                                	ON Away.Id=Matches.AwayTeamId
                                                ORDER BY Matches.HomeTeamScore + Matches.AwayTeamScore DESC";

            migrationBuilder.Sql(getHighlightMatchStoredProcedure);

            var getTopBestOffensiveStoredProcedure = $@"CREATE OR ALTER PROCEDURE {GetTopBestOffensiveStoredProcedureName} @Count int
                                                AS
                                                SELECT TOP (@Count)
                                                	Matches.Id,
                                            	Matches.HomeTeamId,
                                            	Home.Name AS HomeTeam,
                                            	Matches.AwayTeamId,
                                            	Away.Name AS AwayTeam,
                                            	Matches.AwayTeamScore,
                                            	Matches.HomeTeamScore,
                                            	(SELECT Max(v) 
                                            		FROM (VALUES (Matches.AwayTeamScore), (Matches.HomeTeamScore)) AS value(v)) as QueryScore
                                                FROM Matches
                                                JOIN Teams AS Home 
                                                	ON Home.Id=Matches.HomeTeamId
                                                JOIN Teams AS Away
                                                	ON Away.Id=Matches.AwayTeamId
                                                ORDER BY QueryScore DESC";

            migrationBuilder.Sql(getTopBestOffensiveStoredProcedure);

            var getTopBestDefensiveStoredProcedure = $@"CREATE OR ALTER PROCEDURE {GetTopBestDefensiveStoredProcedureName} @Count int
                                                AS
                                                SELECT TOP (@Count)
                                                	Matches.Id,
                                            	Matches.HomeTeamId,
                                            	Home.Name AS HomeTeam,
                                            	Matches.AwayTeamId,
                                            	Away.Name AS AwayTeam,
                                            	Matches.AwayTeamScore,
                                            	Matches.HomeTeamScore,
                                            	(SELECT Max(v) 
                                            		FROM (VALUES (Matches.AwayTeamScore), (Matches.HomeTeamScore)) AS value(v)) as QueryScore
                                                FROM Matches
                                                JOIN Teams AS Home 
                                                	ON Home.Id=Matches.HomeTeamId
                                                JOIN Teams AS Away
                                                	ON Away.Id=Matches.AwayTeamId
                                                ORDER BY QueryScore";

            migrationBuilder.Sql(getTopBestDefensiveStoredProcedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DROP PROCEDURE {GetHighlightMatchStoredProcedureName}");

            migrationBuilder.Sql($"DROP PROCEDURE {GetTopBestOffensiveStoredProcedureName}");

            migrationBuilder.Sql($"DROP PROCEDURE {GetTopBestDefensiveStoredProcedureName}");
        }
    }
}
