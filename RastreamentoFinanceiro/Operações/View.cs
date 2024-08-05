using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class View
  {
    public static void ViewItem(string expenseOrRevenue)
    {
      Console.Clear();
      Expenses_and_Revenues? item;
      int id = Questions.GetId("vizualizar");

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
        Expenses_and_Revenues.PrintItem(item);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Não existe esse id na lista.");
        return;
      }
    }
  }
}
