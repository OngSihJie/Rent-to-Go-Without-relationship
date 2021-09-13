using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_to_Go_Without_relationship.Migrations
{
    public partial class RentToGoWithoutRelaionsip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agent_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Office_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cust_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cust_Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_WeeklyRent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Number_of_Bedrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Number_of_Bathrooms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Property_Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
