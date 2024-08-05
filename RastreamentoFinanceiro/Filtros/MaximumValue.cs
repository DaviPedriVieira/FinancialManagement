using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class MaximumValue
  {
    public static void FilterByMaximumValue()
    {
      Expenses_and_Revenues? biggestExpense, biggestRevenue;

      Console.Clear();

      if (Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há depesas nem receitas cadastradas.");
        return;
      }

      biggestExpense = Expenses_and_Revenues.expenses.Max();
      biggestRevenue = Expenses_and_Revenues.revenues.Max();

      if (biggestExpense != null)
      {
        List<Expenses_and_Revenues> maioresexpenses = Expenses_and_Revenues.expenses.Where(expense => expense.GetValue() == biggestExpense.GetValue()).ToList();

        Console.WriteLine("\nMaior despesa: ");
        foreach (Expenses_and_Revenues expense in maioresexpenses)
        {
          Expenses_and_Revenues.PrintItem(expense);
        }
      }
      else
      {
        Console.WriteLine("\nNão há depesas cadastradas.");
      }

      if (biggestRevenue != null)
      {
        List<Expenses_and_Revenues> maioresrevenues = Expenses_and_Revenues.revenues.Where(revenue => revenue.GetValue() == biggestRevenue.GetValue()).ToList();

        Console.WriteLine("\nMaior receita: ");
        foreach (Expenses_and_Revenues revenue in maioresrevenues)
        {
          Expenses_and_Revenues.PrintItem(revenue);
        }
      }
      else
      {
        Console.WriteLine("\nNão há receitas cadastradas.");
      }
    }

  }
}
