using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentInformation.Models
{
    public class StudentInfo
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public int Mark { get; set; }
    }
   
}