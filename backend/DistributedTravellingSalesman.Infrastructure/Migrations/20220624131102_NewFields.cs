using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DistributedTravellingSalesman.Infrastructure.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetNumber",
                table: "Parcels",
                newName: "HouseNumber");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Parcels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Parcels");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "Parcels",
                newName: "StreetNumber");
        }
    }
}
