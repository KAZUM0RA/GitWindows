namespace Events;
public class Button
{
    public string? Name { get; set; }
    public event ButtonDelegate? OnClick;
    public void Click()
    {
        Console.WriteLine($"Button '{Name}' was clicked!");
        
        OnClick?.Invoke();
    }


    public delegate void ButtonDelegate();
}