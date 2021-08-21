using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcceses.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementsDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIdendity = table.Column<long>(type: "bigint", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birtday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimarySchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySchoolRank = table.Column<int>(type: "int", nullable: false),
                    PrimarySchoolComplate = table.Column<bool>(type: "bit", nullable: false),
                    MiddleSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleSchoolRank = table.Column<int>(type: "int", nullable: false),
                    MiddleSchoolComplate = table.Column<bool>(type: "bit", nullable: false),
                    HighSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighSchoolRank = table.Column<int>(type: "int", nullable: false),
                    HighSchoolComplate = table.Column<bool>(type: "bit", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityRank = table.Column<int>(type: "int", nullable: false),
                    UniversityComplate = table.Column<bool>(type: "bit", nullable: false),
                    DriverLicance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedPrograms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferancedInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferancedPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppliedTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeOfResidance = table.Column<bool>(type: "bit", nullable: false),
                    ExtraShift = table.Column<bool>(type: "bit", nullable: false),
                    Shift = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
