using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoopShoot.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateGetStoredProcedures : Migration
    {
        private const string GetAllTeamsStoredProcedureName = "spGetAllTeams";
        private const string GetAllMatchesStoredProcedureName = "spGetAllMatches";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var getAllTeamsStoredProcedure = $@"CREATE OR ALTER PROCEDURE {GetAllTeamsStoredProcedureName}
                                                AS
                                                SELECT * FROM Teams";

            migrationBuilder.Sql(getAllTeamsStoredProcedure);

            var getAllMatchesStoredProcedure = $@"CREATE OR ALTER PROCEDURE {GetAllMatchesStoredProcedureName}
                                                AS
                                                SELECT * FROM Matches";

            migrationBuilder.Sql(getAllMatchesStoredProcedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DROP PROCEDURE {GetAllTeamsStoredProcedureName}");

            migrationBuilder.Sql($"DROP PROCEDURE {GetAllMatchesStoredProcedureName}");
        }
    }
}
