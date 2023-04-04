using Ur9;
using Ur9.Enums;

var database = new OperationDataBase();

database.AddIncome(OperationCategory.Salary,summa:50);
database.AddExpense(OperationCategory.Chill, summa:5);
database.AddExpense(OperationCategory.Alcohol,summa:10);
database.AddExpense(OperationCategory.Products,summa:4);
database.AddExpense(OperationCategory.Transport,summa:3);
database.AddExpense(OperationCategory.Medicine,summa:3);
database.AddIncome(OperationCategory.Salary,summa:50);

