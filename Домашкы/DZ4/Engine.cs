public class Engine {
    public double Power {get ; set;} 
    public double State {get ; set;} 

    public override string ToString()
    {
        return $"Мощность двигателя : {Power}\n  Состояние {State} ";
    }
}