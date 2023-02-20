public class Engine {
    public double Power {get ; set;} 
    public double State {get ; set;} 

    public override string ToString()
    {
        return $"мощность двигателя : {Power}\n Состояние {State} ";
    }
}