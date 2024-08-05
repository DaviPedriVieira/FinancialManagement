using RastreamentoFinanceiro.Classes;

namespace RastreamentoFinanceiro.Operações
{
  internal class ViewAll
  {
    public static void ViewAllItems(string expenseOrRevenue)
    {
      Console.Clear();

      if (expenseOrRevenue == "expense")
      {
        if (Expenses_and_Revenues.expenses.Count > 0)
        {
          foreach (Expenses_and_Revenues expense in Expenses_and_Revenues.expenses)
          {
            Expenses_and_Revenues.PrintItem(expense);
          }
        }
        else
        {
          Console.Clear();
          Console.WriteLine("Não há despesas cadastradas");
          return;
        }
      }
      else
      {
        if (Expenses_and_Revenues.revenues.Count > 0)
        {
          foreach (Expenses_and_Revenues revenue in Expenses_and_Revenues.revenues)
          {
            Expenses_and_Revenues.PrintItem(revenue);
          }
        }
        else
        {
          Console.Clear();
          Console.WriteLine("Não há receitas cadastradas.");
          return;
        }
      }
    }
  }
}
