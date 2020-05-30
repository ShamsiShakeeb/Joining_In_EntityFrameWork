using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Joining_In_EF.Models
{
    public class Student_And_Subject
    {
        [Key]
        public int ID { set; get; }

        [ForeignKey("Student")]
        public int Student_ID { set; get; }

        public Student Student { set; get; }

        [ForeignKey("Subject")]
        public int Subject_ID { set; get; }

        public Subject Subject { set; get; }

        /*
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

          */
       
    }
}
