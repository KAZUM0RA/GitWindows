// void SayHello(){
//     Console.WriteLine("Hello world");
// }

// MyDelegate? del = null;
// del?.Invoke();

// delegate void MyDelegate();

using ur10;

//Console.WriteLine(MathOperations.Multiply(a:5, b:8));

// MathDelegate del = MathOperations.Minus;
// double result = del.Invoke(a:8, b:2);
// Console.WriteLine(result);

// void Calculate(double a, double b, MathDelegate operation)
// {
//     double result = operation.Invoke(a, b);
//     Console.WriteLine("Result: " + result);
// }

// Calculate(a:5, b:8, MathOperations.Multiply);
// Calculate(a:5, b:8, MathOperations.Divide);


// delegate double MathDelegate(double a, double b);


using Events;

var button1 = new Button {Name = "FirstButton"};
button1.OnClick += CreateHelloFile;

button1.Click();


void CreateHelloFile()
{
    using var witer = new StreamWriter (path:"json");
    witer.WriteLine("Hello");

}