using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SurveyUP.Migrations.N3mikos
{
    public partial class reorg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionGroups",
                table: "vts_tbQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionSelectionMode",
                table: "vts_tbQuestion");

            migrationBuilder.DropTable(
                name: "vts_tbQuestionGroups");


            migrationBuilder.DropColumn(
                name: "LanguageCode",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "ProgressSaveDate",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "ResumeAtPageNumber",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "ResumeHighestPageNumber",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "ResumeQuestionNumber",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "ResumeUID",
                table: "vts_tbVoter");

            migrationBuilder.DropColumn(
                name: "AccessPassword",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "AllowMultipleNSurveySubmissions",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "AllowMultipleUserNameSubmissions",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "CookieExpires",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "DefaultSurvey",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "FriendlyName",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "IPExpires",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "LastEntryDate",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "MultiLanguageModeId",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "MultiLanguageVariable",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "NavigationEnabled",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "NotificationModeID",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "OnlyInvited",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "ProgressDisplayModeId",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "QuestionNumberingDisabled",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "RedirectionURL",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "ResultsDisplayTimes",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "ResumeModeID",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "SaveTokenUserData",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "UnAuthentifiedUserActionID",
                table: "vts_tbSurvey");

            migrationBuilder.DropColumn(
                name: "ParentQuestionId",
                table: "vts_tbQuestion");

            migrationBuilder.DropColumn(
                name: "SelectionModeId",
                table: "vts_tbQuestion");

            migrationBuilder.AddColumn<byte>(
                name: "SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vts_tbQuestion_SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion",
                column: "SelectionModeQuestionSelectionModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionSelectionMode_SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion",
                column: "SelectionModeQuestionSelectionModeId",
                principalTable: "vts_tbQuestionSelectionMode",
                principalColumn: "QuestionSelectionModeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionSelectionMode_SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion");

            migrationBuilder.DropIndex(
                name: "IX_vts_tbQuestion_SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion");

            migrationBuilder.DropColumn(
                name: "SelectionModeQuestionSelectionModeId",
                table: "vts_tbQuestion");

            migrationBuilder.AddColumn<string>(
                name: "LanguageCode",
                table: "vts_tbVoter",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProgressSaveDate",
                table: "vts_tbVoter",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResumeAtPageNumber",
                table: "vts_tbVoter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResumeHighestPageNumber",
                table: "vts_tbVoter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResumeQuestionNumber",
                table: "vts_tbVoter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResumeUID",
                table: "vts_tbVoter",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccessPassword",
                table: "vts_tbSurvey",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllowMultipleNSurveySubmissions",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<bool>(
                name: "AllowMultipleUserNameSubmissions",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<int>(
                name: "CookieExpires",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true,
                defaultValueSql: "((1440))");

            migrationBuilder.AddColumn<bool>(
                name: "DefaultSurvey",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FriendlyName",
                table: "vts_tbSurvey",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IPExpires",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true,
                defaultValueSql: "((1440))");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEntryDate",
                table: "vts_tbSurvey",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MultiLanguageModeId",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<string>(
                name: "MultiLanguageVariable",
                table: "vts_tbSurvey",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NavigationEnabled",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<int>(
                name: "NotificationModeID",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true,
                defaultValueSql: "((1))");

            migrationBuilder.AddColumn<bool>(
                name: "OnlyInvited",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<int>(
                name: "ProgressDisplayModeId",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true,
                defaultValueSql: "((2))");

            migrationBuilder.AddColumn<bool>(
                name: "QuestionNumberingDisabled",
                table: "vts_tbSurvey",
                type: "bit",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<string>(
                name: "RedirectionURL",
                table: "vts_tbSurvey",
                type: "varchar(1024)",
                unicode: false,
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultsDisplayTimes",
                table: "vts_tbSurvey",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "ResumeModeID",
                table: "vts_tbSurvey",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "((1))");

            migrationBuilder.AddColumn<int>(
                name: "SaveTokenUserData",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnAuthentifiedUserActionID",
                table: "vts_tbSurvey",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentQuestionId",
                table: "vts_tbQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "SelectionModeId",
                table: "vts_tbQuestion",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "((0))");

            migrationBuilder.CreateTable(
                name: "vts_tbQuestionGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ParentGroupID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vts_tbQuestionGroups", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vts_tbQuestion_SelectionModeId",
                table: "vts_tbQuestion",
                column: "SelectionModeId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupName",
                table: "vts_tbQuestionGroups",
                columns: new[] { "GroupName", "ParentGroupID" })
                .Annotation("SqlServer:FillFactor", 80);

            migrationBuilder.CreateIndex(
                name: "IX_ParentGroupID",
                table: "vts_tbQuestionGroups",
                column: "ParentGroupID")
                .Annotation("SqlServer:FillFactor", 80);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionGroups",
                table: "vts_tbQuestionGroups",
                column: "DisplayOrder")
                .Annotation("SqlServer:FillFactor", 80);

            migrationBuilder.AddForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionGroups",
                table: "vts_tbQuestion",
                column: "QuestionGroupID",
                principalTable: "vts_tbQuestionGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vts_tbQuestion_vts_tbQuestionSelectionMode",
                table: "vts_tbQuestion",
                column: "SelectionModeId",
                principalTable: "vts_tbQuestionSelectionMode",
                principalColumn: "QuestionSelectionModeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
