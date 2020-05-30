using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Joining_In_EF.Models
{
    public class Student
    {
        [Key]
        public int Student_ID { set; get; }

        public String Name { set; get; }

        public String Phone { set; get; }

        
        public List<Student_And_Subject> Student_Join_Subject { set; get; }

    }
}
