public class Cars {
    public string? Name {get; set; }
    public string? Models {get ; set;}

    public double  Speed {get; set;}
    public Engine Engine {get ; set ; } = new Engine(){
        Power = 100 ,
        State = 100
    }; 
     public override string ToString(){
        return $"\n Машина: {Name}\n Модель: {Models}\n Скорость: {Speed}\n Состояние двигателя: {Engine}%\n ";
     }
     public bool Start() {

     if (Engine.Power == 0 || Engine.State == 0)
     throw new Exception("Ошибка, мощность или состояние двигателя равно нулю");

     return true;
     }
}