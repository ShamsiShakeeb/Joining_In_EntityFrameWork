using Microsoft.EntityFrameworkCore.Migrations;

namespace Joining_In_EF.Migrations
{
    public partial class DatabaseFile7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID",
                table: "Student_And_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID",
                table: "Student_And_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_And_Subject_Student_ID",
                table: "Student_And_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_And_Subject_Subject_ID",
                table: "Student_And_Subject");

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

            migrationBuilder.CreateIndex(
                name: "IX_Student_And_Subject_Student_ID",
                table: "Student_And_Subject",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_And_Subject_Subject_ID",
                table: "Student_And_Subject",
                column: "Subject_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID",
                table: "Student_And_Subject",
                column: "Student_ID",
                principalTable: "student",
                principalColumn: "Student_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID",
                table: "Student_And_Subject",
                column: "Subject_ID",
                principalTable: "subject",
                principalColumn: "Subject_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
