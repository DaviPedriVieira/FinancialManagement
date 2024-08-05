using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class Edit
  {
    public static void EditItem(string expenseOrRevenue)
    {
      Console.Clear();
      Expenses_and_Revenues? item;
      int id = Questions.GetId("editar");

      if (expenseOrRevenue == "expense")
      {
        item = Expenses_and_Revenues.expenses.Find(expense => expense.GetId() == id);
      }
      else if (expenseOrRevenue == "revenue")
      {
        item = Expenses_and_Revenues.revenues.Find(revenue => revenue.GetId() == id);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Não existe esse id na lista.");
        return;
      }

      DateOnly date = Questions.GetDate($"da {expenseOrRevenue}");
      double value = Questions.GetValue($"da {expenseOrRevenue}");
      string description = Questions.GetDescription($"da {expenseOrRevenue}");
      string category = Questions.GetCategory($"da {expenseOrRevenue}");

      if (item != null)
      {
        item.SetDate(date);
        item.SetValue(value);
        item.SetDescription(description);
        item.SetCategory(category);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Não existe esse id na lista.");
        return;
      }

      Console.Clear();
      Console.WriteLine($"{expenseOrRevenue} atualizada.");
    }

  }
}
