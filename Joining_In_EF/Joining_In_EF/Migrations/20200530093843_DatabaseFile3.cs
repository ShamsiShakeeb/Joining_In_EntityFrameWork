using Microsoft.EntityFrameworkCore.Migrations;

namespace Joining_In_EF.Migrations
{
    public partial class DatabaseFile3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Student_ID1",
                table: "Student_And_Subject",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subject_ID1",
                table: "Student_And_Subject",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_And_Subject_Student_ID1",
                table: "Student_And_Subject",
                column: "Student_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Student_And_Subject_Subject_ID1",
                table: "Student_And_Subject",
                column: "Subject_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID1",
                table: "Student_And_Subject",
                column: "Student_ID1",
                principalTable: "student",
                principalColumn: "Student_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID1",
                table: "Student_And_Subject",
                column: "Subject_ID1",
                principalTable: "subject",
                principalColumn: "Subject_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID1",
                table: "Student_And_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID1",
                table: "Student_And_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_And_Subject_Student_ID1",
                table: "Student_And_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_And_Subject_Subject_ID1",
                table: "Student_And_Subject");

            migrationBuilder.DropColumn(
                name: "Student_ID1",
                table: "Student_And_Subject");

            migrationBuilder.DropColumn(
                name: "Subject_ID1",
                table: "Student_And_Subject");
        }
    }
}
