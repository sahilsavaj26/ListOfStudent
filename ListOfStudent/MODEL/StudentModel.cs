using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStudent.Model
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? RollNo { get; set; }
        public string? Gender { get; set; }
        public DateTime DOB { get; set; }
        public int Std { get; set; }

    }
}