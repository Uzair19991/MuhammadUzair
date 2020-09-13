using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentInformation.Models
{
    public class StudentDb : DbContext
    {
        public StudentDb() : base("StudentDb")
        {

        }
        public DbSet<StudentInfo> studentInfos { get; set; }
    }
}