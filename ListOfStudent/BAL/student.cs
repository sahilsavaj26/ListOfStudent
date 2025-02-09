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
        public List<string> GetFullNames()
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
        public List<string> GetaStudentRollNo()
        {
            List<StudentModel> studentR = GetStudentList();

            foreach (StudentModel student in studentR)
            {
                Console.WriteLine($"{student.Name.ToUpper()}");
            }
            return studentR.Select(x => x.Name).ToList();
        }

        //Change Surname In Student 
        public List<string> GetStudentNewName(string oldName, string NewName)
        {
            List<StudentModel> studentName = GetStudentList();
            foreach (StudentModel student in studentName)
            {
                if (student.SurName == oldName)
                {
                    student.SurName = NewName;
                }
            }
            return studentName.Select(x => x.SurName).ToList();
        }

        // Roll_No in a # use

        public List<string> ReplaceRollNo()
        {
            List<StudentModel> StudentRollNo = GetStudentList();

            foreach (StudentModel student in StudentRollNo)
            {
                if (student.RollNo == "RL_1")
                {
                    student.RollNo = "#1";
                }
                else if (student.RollNo == "RL_2")
                {
                    student.RollNo = "#2";
                }
                else if (student.RollNo == "RL_3")
                {
                    student.RollNo = "#3";
                }
            }
            return StudentRollNo.Select(x => x.RollNo).ToList();

        }

        //Age Range 
        public List<string> AgeRange(int FirstRange, int SecondRange)
        {
            List<StudentModel> StudentAge = GetStudentList();
            List<StudentModel> ReturnList = new List<StudentModel>();
            int CurrentYear = DateTime.Now.Year;
            foreach (StudentModel student in StudentAge)
            {
                //ReturnList.Add(student);
                if (student.DOB.Year <= DateTime.Now.AddYears(-FirstRange).Year && student.DOB.Year >= DateTime.Now.AddYears(-SecondRange).Year)
                {
                    ReturnList.Add(student);
                }
            }
            return ReturnList.Select(x => x.Name + "- Year of birth: " + x.DOB.Year + " Age: " + (CurrentYear - x.DOB.Year)).ToList();
        }

        //First Latter Add And Get a Student Name:

        public List<string> Startwith()
        {
            List<StudentModel> Firstlatter = GetStudentList();
            List<StudentModel> ReturnList = new List<StudentModel>();
            Console.WriteLine("Enter your first letter");
            string Fname = Console.ReadLine();
            foreach (StudentModel student in Firstlatter)
            {
                if (student.Name.StartsWith(Fname))
                {
                    ReturnList.Add(student);
                }
            }
           return ReturnList.Select(x => x.Name).ToList();
           return ReturnList.Select(static x => x.SurName).ToList();

        }

    }
    }


