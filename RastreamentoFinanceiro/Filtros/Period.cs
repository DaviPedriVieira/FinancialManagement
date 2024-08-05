using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Filtros
{
  internal class Period
  {
    public static void FilterByPeriod()
    {
      Console.Clear();

      if (Expenses_and_Revenues.expenses.Count == 0 && Expenses_and_Revenues.revenues.Count == 0)
      {
        Console.WriteLine("Não há despesas nem receitas cadastradas.");
        return;
      }

      DateOnly startDate = Questions.GetDate("inicial");
      DateOnly finalDate = Questions.GetDate("final");

      if (startDate > finalDate)
      {
        Console.WriteLine("\nA data inicial informada é maior do que a final.");
        return;
      }

      // expenses
      List<Expenses_and_Revenues> expensesInPeriod = Expenses_and_Revenues.expenses.Where(expense => expense.GetDate() >= startDate && expense.GetDate() <= finalDate).ToList();

      if (expensesInPeriod.Any())
      {
        Console.WriteLine("\nDespesas:");
        foreach (Expenses_and_Revenues expense in expensesInPeriod)
        {
          Expenses_and_Revenues.PrintItem(expense);
        }
      }
      else
      {
        Console.WriteLine("\nNão há despesas desta categoria.");
        return;
      }

      // Receitas
      List<Expenses_and_Revenues> revenuesInPeriod = Expenses_and_Revenues.expenses.Where(expense => expense.GetDate() >= startDate && expense.GetDate() <= finalDate).ToList();

      if (revenuesInPeriod.Any())
      {
        Console.WriteLine("\nReceitas:");
        foreach (Expenses_and_Revenues revenue in revenuesInPeriod)
        {
          Expenses_and_Revenues.PrintItem(revenue);
        }
      }
      else
      {
        Console.WriteLine("\nNão há receitas desta categoria.");
        return;
      }

      return;
    }
  }
}
