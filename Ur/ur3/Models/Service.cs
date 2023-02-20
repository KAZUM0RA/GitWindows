namespace UR3.Models;

public interface IMovable{
    public double Speed {get; set ;}
    public string? Mover {get ; set ; }

}
public class Auto : IMovable 
{
    public double Speed {get; set ;}
    public string? Mover {get ; set ; }

}
public class Human : IMovable 
{
    public double Speed {get; set ;}
    public string? Mover {get ; set ; }

}