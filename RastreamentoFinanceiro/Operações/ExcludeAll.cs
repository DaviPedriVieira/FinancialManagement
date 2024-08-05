using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class ExcludeAll
  {
    public static void ExcludeAllConfirmation(string expenseOrRevenue)
    {
      Console.Clear();
      Console.WriteLine($"\nDeseja realmente excluir todas as {expenseOrRevenue}, responda com sim ou não: ");
      string confirmation = Console.ReadLine()!.Trim();

      if (confirmation.Equals("sim", StringComparison.OrdinalIgnoreCase))
      {
        ExcludeAllItems(expenseOrRevenue);
        return;
      }
      else
      {
        Console.WriteLine($"\nOk, nenhuma {expenseOrRevenue} foi excluida.");
      }
    }

    private static void ExcludeAllItems(string expenseOrRevenue)
    {
      Console.Clear();

      if (expenseOrRevenue == "expense")
      {
        if (Expenses_and_Revenues.expenses.Count > 0)
        {
          Expenses_and_Revenues.expenses.Clear();
        }
        else
        {
          Console.WriteLine("Não há depesas cadastradas.");
          return;
        }
      }
      else
      {
        if (Expenses_and_Revenues.revenues.Count > 0)
        {
          Expenses_and_Revenues.revenues.Clear();
        }
        else
        {
          Console.WriteLine("Não há receitas cadastradas.");
          return;
        }
      }

      Console.WriteLine($"Todas as {expenseOrRevenue}s foram excluídas.");
    }
  }
}
