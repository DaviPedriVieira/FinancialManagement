using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class Add
  {
    public static void AddItem(string expenseOrRevenue)
    {
      Console.Clear();

      int id;
      DateOnly date = Questions.GetDate($"da {expenseOrRevenue}");
      double value = Questions.GetValue($"da {expenseOrRevenue}");
      string description = Questions.GetDescription($"da {expenseOrRevenue}");
      string category = Questions.GetCategory($"da {expenseOrRevenue}");

      if (expenseOrRevenue == "expense")
      {
        id = Expenses_and_Revenues.expenses.Count == 0 ? 1 : Expenses_and_Revenues.expenses.Max(expense => expense.GetId() + 1);
      }
      else
      {
        id = Expenses_and_Revenues.revenues.Count == 0 ? 1 : Expenses_and_Revenues.revenues.Max(revenue => revenue.GetId() + 1);
      }

      Expenses_and_Revenues item = new Expenses_and_Revenues(id, date, value, description, category);
      
      if (expenseOrRevenue == "expense")
      {
        Expenses_and_Revenues.Addexpense(item);
      }
      else
      {
        Expenses_and_Revenues.Addrevenue(item);
      }

      Console.Clear();
      Console.WriteLine($"{expenseOrRevenue} criada.");
    }
  }
}
