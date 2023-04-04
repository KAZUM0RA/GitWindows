using Ur9.Enums;

namespace Ur9;

public class OperationDataBase
{
    private readonly List<Operation> _operations = new List<Operation>();

    public void AddIncome(OperationCategory category , decimal summa ,string? comment=null)
    {
        var operation = new Operation
        {
            Type = OperationType.Income,
            CreatedAt = DateTime.Now,
            
            Category = category,
            Comment = comment,
            Summa = summa
        };

        _operations.Add(operation);
    }
    public void AddExpense(OperationCategory category , decimal summa ,string? comment=null)
    {
        var operation = new Operation
        {
            Type = OperationType.Expense,
            CreatedAt = DateTime.Now,

            Category = category,
            Comment = comment,
            Summa = summa
        };

        _operations.Add(operation);
    }
}
    
