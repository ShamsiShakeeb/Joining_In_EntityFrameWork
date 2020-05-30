using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joining_In_EF.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Student> student { get; set; }
        public DbSet<Subject> subject { get; set; }
        public DbSet<Student_And_Subject> Student_And_Subject { get; set; }
    }
}
