using UR3.Models;

IMovable[] mover = new IMovable[]{
    new Auto {
        Speed = 90,
        Mover = "BMW"
    },
    new Human {
        Speed = 6,
        Mover = "Vasya"
    },
      new Human {
        Speed = 4,
        Mover = "Igar"
    },
};

foreach (IMovable movers in mover)
{
    if (movers is Human human)
    {
        System.Console.WriteLine(human.Mover);
    }
    else if (movers is Auto auto)
    {
        System.Console.WriteLine("it's a car");

    }
}