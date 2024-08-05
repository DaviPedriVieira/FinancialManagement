using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class MinimumValue
  {
    public static void FilterByMinimumValue()
    {
      Expenses_and_Revenues? smallestExpense, smallestRevenue;

      Console.Clear();

      if(Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há despesas nem receitas cadastradas.");
        return;
      }

      smallestExpense = Expenses_and_Revenues.expenses.Min();
      smallestRevenue = Expenses_and_Revenues.revenues.Min();

      if (smallestExpense != null)
      {
        List<Expenses_and_Revenues> menoresexpenses = Expenses_and_Revenues.expenses.Where(expense => expense.GetValue() == smallestExpense.GetValue()).ToList();

        Console.WriteLine("\nMenor despesa: ");
        foreach (Expenses_and_Revenues expense in menoresexpenses)
        {
          Expenses_and_Revenues.PrintItem(expense);
        }
      }
      else
      {
        Console.WriteLine("\nNão há depesas cadastradas.");
      }

      if (smallestRevenue != null)
      {
        List<Expenses_and_Revenues> menoresrevenues = Expenses_and_Revenues.revenues.Where(revenue => revenue.GetValue() == smallestRevenue.GetValue()).ToList();

        Console.WriteLine("\nMenor receita: ");
        foreach (Expenses_and_Revenues revenue in menoresrevenues)
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
