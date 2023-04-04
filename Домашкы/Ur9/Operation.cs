using Ur9.Enums;

namespace Ur9;

public class Operation
{
    public OperationType Type { get; set; }
    public OperationCategory Category { get; set; }
    
    public decimal Summa { get; set; }
    public string? Comment { get; set; }
    public DateTime CreatedAt { get; set; }

    public override string ToString()
    {
        return $"{Type} | {Category} | {Summa}$ | Comment :{Comment} | {CreatedAt}";
    }
}