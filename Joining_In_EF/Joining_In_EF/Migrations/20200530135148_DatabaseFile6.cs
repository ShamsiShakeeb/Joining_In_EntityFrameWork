using Microsoft.EntityFrameworkCore.Migrations;

namespace Joining_In_EF.Migrations
{
    public partial class DatabaseFile6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID",
                table: "Student_And_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID",
                table: "Student_And_Subject");

            migrationBuilder.AlterColumn<int>(
                name: "Subject_ID",
                table: "Student_And_Subject",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Student_ID",
                table: "Student_And_Subject",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID",
                table: "Student_And_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID",
                table: "Student_And_Subject");

            migrationBuilder.AlterColumn<int>(
                name: "Subject_ID",
                table: "Student_And_Subject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Student_ID",
                table: "Student_And_Subject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_student_Student_ID",
                table: "Student_And_Subject",
                column: "Student_ID",
                principalTable: "student",
                principalColumn: "Student_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_And_Subject_subject_Subject_ID",
                table: "Student_And_Subject",
                column: "Subject_ID",
                principalTable: "subject",
                principalColumn: "Subject_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
