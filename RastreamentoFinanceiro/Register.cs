using RastreamentoFinanceiro.Operações;

namespace RastreamentoFinanceiro
{
  internal class Register
  {
    public static void RegisterMenu(string expenseOrRevenue)
    {
      Console.Clear();

      while (true)
      {
        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"                                                  Menu de {expenseOrRevenue}s");
        Console.WriteLine("Selecione o que deseja fazer: ");
        Console.WriteLine($"1. Adicionar {expenseOrRevenue}");
        Console.WriteLine($"2. Visualizar todas as {expenseOrRevenue}s");
        Console.WriteLine($"3. Visualizar uma {expenseOrRevenue}");
        Console.WriteLine($"4. Editar {expenseOrRevenue}");
        Console.WriteLine($"5. Excluir uma {expenseOrRevenue}");
        Console.WriteLine($"6. Excluir todas as {expenseOrRevenue}s");
        Console.WriteLine("7. Voltar para o menu principal");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        string option = Console.ReadLine()!;

          switch (option)
          {
            case "1":
              Add.AddItem(expenseOrRevenue);
              break;
            case "2":
              ViewAll.ViewAllItems(expenseOrRevenue);
              break;
            case "3":
              View.ViewItem(expenseOrRevenue);
              break;
            case "4":
              Edit.EditItem(expenseOrRevenue);
              break;
            case "5":
              Exclude.ExcludeItem(expenseOrRevenue);
              break;
            case "6":
              ExcludeAll.ExcludeAllConfirmation(expenseOrRevenue);
              break;
            case "7":
              Console.Clear();
              return;
            default:
              Console.Clear();
              Console.WriteLine("Digite uma opção válida!");
              break;
          }
   
      }
    }

  }
}
