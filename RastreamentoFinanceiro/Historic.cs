using RastreamentoFinanceiro.Filtros;

namespace RastreamentoFinanceiro
{
  internal class Historic
  {
    public static void HistoricMenu()
    {
      Console.Clear();

      while (true)
      {
        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                        Histórico\n");
        Console.WriteLine("Selecione o método de filtragem que deseja usar: ");
        Console.WriteLine("1. Por período (ex: 01/05/2024 à 30/05/2024)");
        Console.WriteLine("2. Por valor mínimo");
        Console.WriteLine("3. Por valor máximo");
        Console.WriteLine("4. Por descrição");
        Console.WriteLine("5. Por categoria");
        Console.WriteLine("6. Mostrar todos");
        Console.WriteLine("7. Voltar para o menu principal");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        string option = Console.ReadLine()!;

        switch (option)
        {
          case "1":
            Period.FilterByPeriod();
            break;
          case "2":
            MinimumValue.FilterByMinimumValue();
            break;
          case "3":
            MaximumValue.FilterByMaximumValue();
            break;
          case "4":
            Description.FilterByDescription();
            break;
          case "5":
            Category.FilterByCategory();
            break;
          case "6":
            ShowAll.ShowAllItems();
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
