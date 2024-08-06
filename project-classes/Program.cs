// See https://aka.ms/new-console-template for more information
using project_classes;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

Student[] students = new Student[5];
for (int i = 0; i < students.Length; i++)
{
    Student newstudent = new Student(i, "student" + i.ToString(),"generate", 100);
    students[i] = newstudent;

}

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i].FirstName + " " + students[i].AverageGrads);
}

Student findStudentById(int id, Student[] students)
{
    for (global::System.Int32 i = 0; i < students.Length; i++)
    {
        if(students[i].Id == id) {
            return students[i];
        }
    }
    return null;
}

int getAverage(Student[] students)
{
    int average = 0;
    for (global::System.Int32 i = 0; i < students.Length; i++)
    {
        average += students[i].AverageGrads;
    }
    return average / students.Length;
}
Console.WriteLine(getAverage(students));

int nevigateToGameroom(string gameName)
{

    switch (gameName)
    {
        case "lego":
            return 401;
        case "pazel":
            return 502;
        case "videoGame":
            return 603;
    }
    return 0;
}
Console.WriteLine(nevigateToGameroom("lego"));

int[] numbers = { 1, 2, 3, 4, 5, 6 };
static bool isNotFour(int n)
{
    return n != 1;
}
numbers = Array.FindAll(numbers, isNotFour).ToArray();
Console.WriteLine(numbers[0]);

