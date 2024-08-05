using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class Exclude
  {
    public static void ExcludeItem(string expenseOrRevenue)
    {
      Console.Clear();
      Expenses_and_Revenues? item;
      int id = Questions.GetId("excluir");

      if (expenseOrRevenue == "expense")
      {
        item = Expenses_and_Revenues.expenses.Find(expense => expense.GetId() == id);
      }
      else
      {
        item = Expenses_and_Revenues.revenues.Find(revenue => revenue.GetId() == id);
      }

      if(item != null)
      {
        bool Remove = expenseOrRevenue == "expense" ? Expenses_and_Revenues.expenses.Remove(item) : Expenses_and_Revenues.revenues.Remove(item);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Não existe esse id na lista.");
        return;
      }

      Console.Clear();
      Console.WriteLine($"{expenseOrRevenue} excluída!");
    }

  }
}
