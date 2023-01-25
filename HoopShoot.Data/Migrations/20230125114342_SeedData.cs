using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoopShoot.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        private const string SeedTeamsStoredProcedureName = "spSeedTeamsData";
        private const string SeedMatchesStoredProcedureName = "spSeedMatchesData";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var rng = new Random();
            var seedTeamsStoredProcedure = $@"CREATE OR ALTER PROCEDURE {SeedTeamsStoredProcedureName}
                                        AS
                                        INSERT INTO Teams
                                        VALUES
                                            ('Chicago Bulls', '{date}', '{date}', NULL, 0),
                                            ('Los Angeles Lakers', '{date}', '{date}', NULL, 0),
                                            ('New York Knicks', '{date}', '{date}', NULL, 0),
                                            ('Boston Celtics', '{date}', '{date}', NULL, 0),
                                            ('Miami Heat', '{date}', '{date}', NULL, 0),
                                            ('Phoenix Suns', '{date}', '{date}', NULL, 0),
                                            ('Minnesota Timberwolves', '{date}', '{date}', NULL, 0)";

            migrationBuilder.Sql(seedTeamsStoredProcedure);

            var seedMatchesStoredProcedure = $@"CREATE OR ALTER PROCEDURE {SeedMatchesStoredProcedureName}
                                        AS
                                        INSERT INTO Matches
                                        VALUES
                                            (1, 2, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (1, 3, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (1, 4, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (2, 5, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (2, 6, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (2, 7, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (3, 1, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (3, 2, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            (3, 4, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 4, 5, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 4, 6, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 4, 7, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 5, 1, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 5, 2, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 5, 3, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 6, 4, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 6, 5, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 6, 7, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 7, 1, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 7, 2, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0),
                                            ( 7, 3, {rng.Next(200)}, {rng.Next(200)}, '{date}', '{date}', NULL, 0)";

            migrationBuilder.Sql(seedMatchesStoredProcedure);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DROP PROCEDURE {SeedTeamsStoredProcedureName}");

            migrationBuilder.Sql($"DROP PROCEDURE {SeedMatchesStoredProcedureName}");
        }
    }
}
