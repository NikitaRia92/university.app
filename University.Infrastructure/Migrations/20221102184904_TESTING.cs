using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Infrastructure.Migrations
{
    public partial class TESTING : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfirmationEnrollments",
                columns: table => new
                {
                    ApplicantCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FullNameOfApplicant = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ApplicationNumber = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    DateSubmissionApplication = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 11, 2, 19, 49, 4, 163, DateTimeKind.Local).AddTicks(3300))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmationEnrollments", x => x.ApplicantCode);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "FormedGroups",
                columns: table => new
                {
                    RegistryNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SpecialtyCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    GroupNumber = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    NumberOfStudentsInAGroup = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormedGroups", x => x.RegistryNumber);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupNumber = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    CourceNumber = table.Column<int>(type: "int", maxLength: 1, nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SpecialtyCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LevelsOfStudyAtTheUniversity = table.Column<char>(type: "nvarchar(1)", nullable: false),
                    MinimumPassingScore = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Price = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    NumberOfFreeSeats = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Statements",
                columns: table => new
                {
                    ApplicantCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FullNameOfApplicant = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SpecialtyCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    SchoolCertificat = table.Column<bool>(type: "bit", nullable: false),
                    FormOfEducation = table.Column<int>(type: "int", nullable: false),
                    NumberOfPointsScore = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Confirmation = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateSubmissionDocuments = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateAcceptanceDocuments = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statements", x => x.ApplicantCode);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FullNameOfStudent = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SpecialtyCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    GroupNumber = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    FormOfEducation = table.Column<int>(type: "int", nullable: false),
                    TuitionPayment = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    StudentEnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GraduationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statements_ApplicantCode",
                table: "Statements",
                column: "ApplicantCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfirmationEnrollments");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "FormedGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Specialities");

            migrationBuilder.DropTable(
                name: "Statements");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
