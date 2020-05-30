using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Joining_In_EF.Models
{
    public class Subject
    {
        [Key]
        public int Subject_ID { set; get; }

        public String Title { set; get; }

        public String Description { set; get; }
       
        public List<Student_And_Subject> Student_Join_Subject { set; get; }


    }
}
