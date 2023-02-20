namespace VpuDotnet.DZ3;

public class Calculator 
{
    public double  Firnum  { get ;set; }
    public double Secnum { get ; set;}

    public double Plus() => Firnum + Secnum;
    public double Minus() => Firnum - Secnum;
    public double Multiply() => Firnum * Secnum;
    public double Divide() => Firnum / Secnum;
    public double Degree() => Math.Pow(Firnum,Secnum);
}