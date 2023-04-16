using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard_iSupport.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iSupportData",
                columns: table => new
                {
                    Number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status_Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Closed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Assignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time_Open__Min_ = table.Column<double>(type: "float", nullable: true),
                    TAT = table.Column<double>(type: "float", nullable: true),
                    Missing_Ticket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sub_Categorization_of_Error = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count_of_Errors = table.Column<double>(type: "float", nullable: false),
                    Reason_for_Escalation_to_the_SME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actual_Person_Handling_the_ticket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Error_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iSupportData", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iSupportData");
        }
    }
}
