// See https://aka.ms/new-console-template for more information
using ListOfStudent.BAL;
using ListOfStudent.Model;

Console.WriteLine("Hello, World!");

Student objStudent = new();
List<string> lstStudentName = objStudent.GetStudentBasedOnAge(24);
foreach (string studentName in lstStudentName)
{
    Console.WriteLine(studentName);
}
List<StudentModel> lstStudent = objStudent.GetStudentList();

//for (int i = 0; i < lstStudent.Count; i++)
//{
//   Console.WriteLine(lstStudent[i].Name);
//}

foreach (StudentModel student in lstStudent)
{
    if (student.Gender == "F")
    {
        Console.WriteLine(student.Name);
    }

    //if(student.DOB)

    //Console.WriteLine(student.Gender == "F" ? student.Name : "Condition Not Satisfied");
}

// NAME RETURN WITH THE SURNAME

Console.WriteLine("\nFull Name : ");
Student obj1Student = new();
List<string> lstStudent2 = obj1Student.GetFullNames();
foreach( string name in lstStudent2)
{
    Console.WriteLine(name);
}

// Student Age

Console.WriteLine("\nstudent Age : ");
List<string> lstStudentName1 = objStudent.GetStudentBasedOnAge(24);
foreach (string studentName in lstStudentName)
{
    Console.WriteLine(studentName);
}

// Get full names in uppercase
Console.WriteLine("\nFull Names (Name + Surname in Uppercase):");
List<string> lstStudent3 = objStudent.GetFullNames();
foreach (string name in lstStudent2)
{
    Console.WriteLine(name.ToUpper());
}

Console.WriteLine("\nName In Uppercase:");
List<string>studentR = objStudent.GetaStudentRollNo();


// change a surname:
Console.WriteLine("\nChange Surname Maheta To Patel : ");
List<string> newStundentNameList = objStudent.GetStudentNewName("Mehta", "Patel");
foreach (string student in newStundentNameList)
{
    Console.WriteLine(student);
}

// Student RollNo Start #

Console.WriteLine("\nStudent RollNo Strat with # : ");
List<string> newStundentRollNoList = objStudent.ReplaceRollNo();
foreach (string student in newStundentRollNoList)
{
    Console.WriteLine(student);
}

//Student Age Between 20 To 25:

Console.WriteLine("\nStudent Age Between 20 To 25 :");
List<string> dobList = objStudent.AgeRange(20, 25);
foreach (string student in dobList)
{
    Console.WriteLine(student);
}

// Student Name Strat With First Latter

List<string> NameStartList = objStudent.Startwith();
foreach (string student in NameStartList)
{
    Console.WriteLine(student);
}
