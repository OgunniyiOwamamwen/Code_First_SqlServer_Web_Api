using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Code_First_SqlServer_Web_Api.Migrations
{
    public partial class Initial_Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    DataOfBirth = table.Column<DateTimeOffset>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DataOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "owamamwen@outlook.com", "Owamamwen", "M", "Ogunniyi", "351-045-9350" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DataOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTimeOffset(new DateTime(1973, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "fede@gmail.com", "Federica", "F", "Dario", "351-105-0380" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
