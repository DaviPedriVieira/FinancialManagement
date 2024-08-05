using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class Description
  {
    public static void FilterByDescription()
    {
      Console.Clear();

      if (Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há depesas nem receitas cadastradas.");
        return;
      }

      string description = Questions.GetDescription("que deseja buscar");

      // expenses
      bool temexpenses = Expenses_and_Revenues.expenses.Any(revenue => revenue.GetDescription() == description);
      if (temexpenses)
      {
        Console.WriteLine("\nDespesas:");
      }
      else
      {
        Console.WriteLine("\nNão há depesas desta categoria.");
        return;
      }

      List<Expenses_and_Revenues> filteredExpenses = Expenses_and_Revenues.expenses.Where(expense => expense.GetDescription() == description).ToList();

      foreach (var item in filteredExpenses)
      {
        Expenses_and_Revenues.PrintItem(item);
      }

      // revenues
      bool temrevenues = Expenses_and_Revenues.revenues.Any(revenue => revenue.GetDescription() == description);
      if (temrevenues)
      {
        Console.WriteLine("\nReceitas:");
      }
      else
      {
        Console.WriteLine("\nNão há receitas desta categoria.");
        return;
      }

      List<Expenses_and_Revenues> filteredRevenues = Expenses_and_Revenues.expenses.Where(revenue => revenue.GetDescription() == description).ToList();

      foreach (var item in filteredRevenues)
      {
        Expenses_and_Revenues.PrintItem(item);
      }

      return;
    }
  }
}
