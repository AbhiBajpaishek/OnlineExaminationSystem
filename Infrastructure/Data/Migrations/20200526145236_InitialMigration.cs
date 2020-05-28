using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PinCode = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationCenters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    TotalSeatCount = table.Column<int>(nullable: false),
                    SeatsAlloted = table.Column<int>(nullable: false),
                    CenterInCharge = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationCenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExaminationCenters_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExaminationCenters_Users_CenterInCharge",
                        column: x => x.CenterInCharge,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CourseAppliedFor = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    ExaminationCenterId = table.Column<int>(nullable: true),
                    ExaminationCenter_Pref1 = table.Column<int>(nullable: true),
                    ExaminationCenter_Pref2 = table.Column<int>(nullable: true),
                    ExaminationCenter_Pref3 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicants_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_Courses_CourseAppliedFor",
                        column: x => x.CourseAppliedFor,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applicants_ExaminationCenters_ExaminationCenterId",
                        column: x => x.ExaminationCenterId,
                        principalTable: "ExaminationCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_ExaminationCenters_ExaminationCenter_Pref1",
                        column: x => x.ExaminationCenter_Pref1,
                        principalTable: "ExaminationCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_ExaminationCenters_ExaminationCenter_Pref2",
                        column: x => x.ExaminationCenter_Pref2,
                        principalTable: "ExaminationCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applicants_ExaminationCenters_ExaminationCenter_Pref3",
                        column: x => x.ExaminationCenter_Pref3,
                        principalTable: "ExaminationCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_AddressId",
                table: "Applicants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_CourseAppliedFor",
                table: "Applicants",
                column: "CourseAppliedFor");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ExaminationCenterId",
                table: "Applicants",
                column: "ExaminationCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ExaminationCenter_Pref1",
                table: "Applicants",
                column: "ExaminationCenter_Pref1");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ExaminationCenter_Pref2",
                table: "Applicants",
                column: "ExaminationCenter_Pref2");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_ExaminationCenter_Pref3",
                table: "Applicants",
                column: "ExaminationCenter_Pref3");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationCenters_AddressId",
                table: "ExaminationCenters",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationCenters_CenterInCharge",
                table: "ExaminationCenters",
                column: "CenterInCharge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "ExaminationCenters");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
