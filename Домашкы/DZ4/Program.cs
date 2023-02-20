var engine = new Engine() {
    Power =130,
    State = 80
};

var car = new Cars(){
    Name = "Ford",
    Models = "Mondeo",
    Speed = 230,
    Engine = engine
};

var carone = new Cars(){
    Name = "Opel",
    Models = "Astra",
    Speed = 180,
    
};
var cartwo = new Cars(){
    Name = "Reno",
    Models = "Logan",
    Speed = 180,
    Engine = new Engine (){
        Power = 110,
        State = 0
    }
};
Console.WriteLine($"{car}\n {carone}\n {cartwo} ");


car.Start();
carone.Start();
cartwo.Start();
