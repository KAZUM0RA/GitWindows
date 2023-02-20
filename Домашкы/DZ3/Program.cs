using VpuDotnet.DZ3;
Console.WriteLine("Введите два числа через ентер ");
var calc = new Calculator(){

 Firnum = double.Parse(Console.ReadLine()),

 Secnum = double.Parse(Console.ReadLine())
};
Console.WriteLine("Добавляем");
Console.WriteLine(calc.Plus());

Console.WriteLine("Отнимаем");
Console.WriteLine(calc.Minus());

Console.WriteLine("Умножаем");
Console.WriteLine(calc.Multiply());

Console.WriteLine("Делим");
Console.WriteLine(calc.Divide());

Console.WriteLine("Подносим в степень");
Console.WriteLine(calc.Degree());