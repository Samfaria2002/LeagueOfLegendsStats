using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueProfileStats.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileContext",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false),
                    Nickname = table.Column<string>(type: "TEXT", nullable: false),
                    Server = table.Column<int>(type: "INTEGER", nullable: false),
                    Rank = table.Column<int>(type: "INTEGER", nullable: false),
                    Tier = table.Column<int>(type: "INTEGER", nullable: false),
                    Pdl = table.Column<int>(type: "INTEGER", nullable: false),
                    Winrate = table.Column<string>(type: "TEXT", nullable: false),
                    MainRole = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondaryRole = table.Column<int>(type: "INTEGER", nullable: false),
                    ProPlayer = table.Column<bool>(type: "INTEGER", nullable: true),
                    Organizacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileContext", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileContext");
        }
    }
}
