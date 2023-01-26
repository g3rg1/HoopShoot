using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoopShoot.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        private const string SeedTeamsStoredProcedureName = "spSeedTeamsData";
        private const string SeedMatchesStoredProcedureName = "spSeedMatchesData";
        private const int MaxPoints = 200;

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var rng = new Random();

            var seedTeamsStoredProcedure = $@"CREATE OR ALTER PROCEDURE {SeedTeamsStoredProcedureName}
                                        AS
                                        INSERT INTO Teams
                                        VALUES
                                            ('Chicago Bulls'),
                                            ('Los Angeles Lakers'),
                                            ('New York Knicks'),
                                            ('Boston Celtics'),
                                            ('Miami Heat'),
                                            ('Phoenix Suns'),
                                            ('Minnesota Timberwolves')";

            migrationBuilder.Sql(seedTeamsStoredProcedure);

            var seedMatchesStoredProcedure = $@"CREATE OR ALTER PROCEDURE {SeedMatchesStoredProcedureName}
                                        AS
                                        INSERT INTO Matches
                                        VALUES
                                            (1, 2, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (1, 3, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (1, 4, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (2, 5, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (2, 6, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (2, 7, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (3, 1, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (3, 2, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (3, 4, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (4, 5, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (4, 6, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (4, 7, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (5, 1, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (5, 2, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (5, 3, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (6, 4, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (6, 5, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (6, 7, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (7, 1, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (7, 2, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)}),
                                            (7, 3, {rng.Next(MaxPoints)}, {rng.Next(MaxPoints)})";

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
