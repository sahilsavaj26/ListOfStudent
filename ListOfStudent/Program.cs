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

Student obj1Student = new();
List<string> lstStudent2 = obj1Student.GetFullNames();
foreach( string name in lstStudent2)
{
    Console.WriteLine(name);
}

// GET FULL NAMES IN A UPPARCASE
Console.WriteLine("\nFull Names (Name + Surname in Uppercase):");
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


