using ListOfStudent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStudent.BAL
{
    public class Student
    {
        public List<StudentModel> GetStudentList()
        {
            List<StudentModel> lstStudent = new();
            lstStudent.Add(new StudentModel()
            {
                Id = 1,
                Name = "Jaypal",
                DOB = DateTime.Now.AddYears(-25),
                Gender = "M",
                RollNo = "RL_1",
                Std = 12,
                SurName = "Vasveliya"
            });
            lstStudent.Add(new StudentModel()
            {
                Id = 2,
                Name = "Milan",
                DOB = DateTime.Now.AddYears(-22),
                Gender = "M",
                RollNo = "RL_2",
                Std = 12,
                SurName = "Gandhi"
            });
            lstStudent.Add(new StudentModel()
            {
                Id = 3,
                Name = "Khushi",
                DOB = DateTime.Now.AddYears(-24),
                Gender = "F",
                RollNo = "RL_3",
                Std = 12,
                SurName = "Mehta"
            });

            return lstStudent;
        }

        public List<string> GetStudentBasedOnAge(int age) //5
        {
            List<StudentModel> lstStudent = GetStudentList(); //3
            int year = DateTime.Now.AddYears(-age).Year; //2020
            List<StudentModel> flterList = new(); //0
            foreach (StudentModel student in lstStudent)
            {
                if (year > student.DOB.Year)//2020 < 2000 
                {
                    flterList.Add(student);
                }
            }
            return flterList.Select(x => x.Name).ToList();
        }

            // NAME RETURN WITH THE SURNAME
           public List <string> GetFullNames()
                {
                    List<StudentModel> lstStudent = GetStudentList();
                    List<string> fullnames = new();

                    foreach (StudentModel student in lstStudent)
                {
                    string fullname = student.Name + " " + student.SurName; fullnames.Add(fullname);
                }
                return fullnames;

                }
        // Get full name (Name + Surname) in uppercase
           public List<string> FullNames()
            {
                List<string> fullNames = new();

                 foreach (StudentModel student in GetStudentList())
            {
                string fullName = (student.Name + " " + student.SurName.ToUpper()); // Convert both name and surname to uppercase
                fullNames.Add(fullName);
            }

            return fullNames;
            }

        // GET NAME IN A UPPAR CASE
        public List<string>GetaStudentRollNo()
        {
            List<StudentModel>studentR = GetStudentList();

            foreach(StudentModel student in studentR)
            {
                Console.WriteLine($"{student.Name.ToUpper()}");
            }
            return studentR.Select(x => x.Name).ToList();
        }
    }
}
    

