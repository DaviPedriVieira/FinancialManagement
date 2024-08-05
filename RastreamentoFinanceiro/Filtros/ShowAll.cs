using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class ShowAll
  {
    public static void ShowAllItems()
    {
      Console.Clear();

      if (Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há despesas nem receitas cadastradas.");
        return;
      }

      // Despesas
      if (Expenses_and_Revenues.expenses.Count > 0)
      {
        Console.WriteLine("Despesas: ");
        foreach (Expenses_and_Revenues expense in Expenses_and_Revenues.expenses)
        {
          Expenses_and_Revenues.PrintItem(expense);
        }
      }
      else
      {
        Console.WriteLine("\nNão há despesas cadastradas.");
      }

      // Receitas
      if (Expenses_and_Revenues.revenues.Count > 0)
      {
        Console.WriteLine("\nReceitas: ");
        foreach (Expenses_and_Revenues revenue in Expenses_and_Revenues.revenues)
        {
          Expenses_and_Revenues.PrintItem(revenue);
        }
      }
      else
      {
        Console.WriteLine("\nNão há receitas cadastradas.");
      }

      return;
    }
  }
}
