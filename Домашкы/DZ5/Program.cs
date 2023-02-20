using System.Linq;
var dz = new List<Dz>(){


new Dz {IdStudent=1, IdTeacher=6, Lesson = "C++", Description = "Cтруктуры",Grade = 11 },
new Dz {IdStudent=1, IdTeacher=4, Lesson = "C#", Description = "Исключения",Grade = 9 },
new Dz {IdStudent=1, IdTeacher=1, Lesson = "UML", Description = "Диаграмы",Grade = 4 },
new Dz {IdStudent=2, IdTeacher=2, Lesson = "C++", Description = "Cтруктуры",Grade = 7 },
new Dz {IdStudent=2, IdTeacher=4, Lesson = "UML", Description = "Диаграмы",Grade = 5 },
new Dz {IdStudent=2, IdTeacher=3, Lesson = "C#", Description = "Исключения",Grade = 12 },
new Dz {IdStudent=3, IdTeacher=5, Lesson = "C#", Description = "Исключения",Grade = 10 },
new Dz {IdStudent=3, IdTeacher=4, Lesson = "UML", Description = "Диаграмы",Grade = 7 },
new Dz {IdStudent=3, IdTeacher=5, Lesson = "C++", Description = "Cтруктуры",Grade = 9 },
new Dz {IdStudent=4, IdTeacher=5, Lesson = "C#", Description = "Исключения",Grade = 11 },
new Dz {IdStudent=4, IdTeacher=6, Lesson = "C++", Description = "Cтруктуры",Grade = 7 },
new Dz {IdStudent=4, IdTeacher=1, Lesson = "UNL", Description = "Диаграмы",Grade = 3 },
new Dz {IdStudent=5, IdTeacher=7, Lesson = "C#", Description = "Исключения",Grade = 11 },
new Dz {IdStudent=5, IdTeacher=7, Lesson = "C++", Description = "Cтруктуры",Grade = 7 },
new Dz {IdStudent=5, IdTeacher=6, Lesson = "UML", Description = "Диаграмы",Grade = 9 },

};

foreach (var Dz in dz )
Console.WriteLine($"id ученика:{Dz.IdStudent} id преподавателя: {Dz.IdTeacher} название предмета:{Dz.Lesson} описание дз:{Dz.Description} оценка: {Dz.Grade} ");

Console.WriteLine(" \n Задание №1 \n ");

// var dzid = from Dz in dz
//                   where Dz.IdStudent == 5
//                   select Dz;

// foreach (var Dz in dzid) 

//   Console.WriteLine($"id ученика:{Dz.IdStudent} id преподаватиля: {Dz.IdTeacher} название предмета:{Dz.Lesson} описание дз:{Dz.Description} оценка: {Dz.Grade} "); 

Dz? dzid = dz.FirstOrDefault (dz => dz.IdStudent == 5 );

if(dzid is not null )

Console.WriteLine($"id ученика:{dzid.IdStudent} id преподавателя: {dzid.IdTeacher} название предмета:{dzid.Lesson} описание дз:{dzid.Description} оценка: {dzid.Grade} ");

else 
Console.WriteLine("Отсутствует");


Console.WriteLine(" \n Задание №2 \n ");

// var dzc = from Dz in dz
//                   where Dz.Lesson == "C++"
//                   select Dz;

// foreach (var Dz in dzc) 

// Console.WriteLine($"id ученика:{Dz.IdStudent} id преподавателя: {Dz.IdTeacher} название предмета:{Dz.Lesson} описание дз:{Dz.Description} оценка: {Dz.Grade} ");

Dz? dzс = dz.FirstOrDefault (dz => dz.Lesson == "C++");

if( dzс is not null )

Console.WriteLine($"id ученика:{dzс.IdStudent} id преподавателя: {dzс.IdTeacher} название предмета:{dzс.Lesson} описание дз:{dzс.Description} оценка: {dzс.Grade} ");

else 
Console.WriteLine("Отсутствует");


Console.WriteLine(" \n Задание №3 \n ");

// var dz5 = from Dz in dz
//                   where Dz.IdTeacher == 1  
//                   where Dz.Grade < 5
//                   select Dz;

// foreach (var Dz in dz5) 

//   Console.WriteLine($"id ученика:{Dz.IdStudent} id преподавателя: {Dz.IdTeacher} название предмета:{Dz.Lesson} описание дз:{Dz.Description} оценка: {Dz.Grade} ");
Dz? dz5 = dz.FirstOrDefault (dz => dz.IdTeacher == 1 && dz.Grade < 5 );



if( dz5 is not null )

Console.WriteLine($"id ученика:{dz5.IdStudent} id преподавателя: {dz5.IdTeacher} название предмета:{dz5.Lesson} описание дз:{dz5.Description} оценка: {dz5.Grade} ");

else 
Console.WriteLine("Отсутствует");


  Console.WriteLine(" \n Задание №4 \n ");

//   var dzidst = from Dz in dz
//                   where Dz.IdStudent == 1  
//                   where Dz.IdTeacher == 6
//                   select Dz;

// foreach (var Dz in dzidst) 

//   Console.WriteLine($"id ученика:{Dz.IdStudent} id преподавателя: {Dz.IdTeacher} название предмета:{Dz.Lesson} описание дз:{Dz.Description} оценка: {Dz.Grade} ");

Dz? dzidst = dz.FirstOrDefault (dz => dz.IdStudent == 1 && dz.IdTeacher == 6 );

if( dzidst is not null )

Console.WriteLine($"id ученика:{dzidst.IdStudent} id преподавателя: {dzidst.IdTeacher} название предмета:{dzidst.Lesson} описание дз:{dzidst.Description} оценка: {dzidst.Grade} ");

else 

Console.WriteLine("Отсутствует");