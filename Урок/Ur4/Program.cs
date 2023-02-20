/*using System.Collections.Generic;

var numbers = new List<int>() {1, 2, 3, 4, 5};

numbers.Add(6);

foreach (int item in numbers)
Console.WriteLine(item);*/

using System.Linq;

var students = new List<Student>()
{
    new Student {Name = "Nikita", Group = "VPU221", AverageMark = 10.7},
    new Student {Name = "Igor", Group = "VHU221", AverageMark = 10.1},
    new Student {Name = "Alina", Group = "VPU421", AverageMark = 10.5},
    new Student {Name = "Innokentiy", Group = "VPU221", AverageMark = 9.7},

};

/*foreach (var student in students)
{
      if(student.AverageMark > 10)
    {
    
    Console.WriteLine ($"Name: {student.Name}, Group: {student.Group}, avg: {student.AverageMark}");
    //$ - интерполяция
    }
}


Console.Write("Введите название группы: ");
    string? searchGroup = Console.ReadLine();
    foreach (var student in students)
{
       if(student.Group.ToUpper() == searchGroup)

    Console.WriteLine ($"Name: {student.Name}, Group: {student.Group}, avg: {student.AverageMark}");
}*/

//linq запрос
/*var bestStudents = from student in students
                  where student.AverageMark >= 10
                  select student;
*/
//более современная версия
//var goodStudents = students.Where(student => student.AverageMark >= 10);

//превращение выборки в вид вписка
List<Student> goodStudents = 
students.Where(student => student.AverageMark >= 10).ToList();

foreach(var student in goodStudents)
Console.WriteLine ($"Name: {student.Name}, Group: {student.Group}, avg: {student.AverageMark}");
