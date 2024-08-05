using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class Category
  {
    public static void FilterByCategory()
    {
      Console.Clear();

      if (Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há depesas nem receitas cadastradas.");
        return;
      }

      string category = Questions.GetCategory("que deseja buscar");

      // expenses
      bool temexpenses = Expenses_and_Revenues.expenses.Any(expense => expense.GetCategory() == category);
      if (temexpenses)
      {
        Console.WriteLine("\nDepesas:");
      }
      else
      {
        Console.WriteLine("\nNão há depesas desta categoria.");
        return;
      }

      List<Expenses_and_Revenues> filteredExpenses = Expenses_and_Revenues.expenses.Where(expense => expense.GetDescription() == category).ToList();

      foreach (var item in filteredExpenses)
      {
        Expenses_and_Revenues.PrintItem(item);
      }

      // revenues
      bool temrevenues = Expenses_and_Revenues.revenues.Any(revenue => revenue.GetCategory() == category);
      if (temrevenues)
      {
        Console.WriteLine("\nReceitas:");
      }
      else
      {
        Console.WriteLine("\nNão há receitas desta categoria.");
        return;
      }

      List<Expenses_and_Revenues> filteredRevenues = Expenses_and_Revenues.expenses.Where(revenue => revenue.GetDescription() == category).ToList();

      foreach (var item in filteredRevenues)
      {
        Expenses_and_Revenues.PrintItem(item);
      }

      return;
    }
  }
}
