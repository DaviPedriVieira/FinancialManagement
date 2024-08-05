using RastreamentoFinanceiro;

public class Program
{
  public static void Main(string[] args)
  {
    Console.Title = "Gerenciamento Financeiro";

    while (true)
    {
      Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
      Console.WriteLine("                                            Gerenciamento Financeiro\n");
      Console.WriteLine("Selecione uma das opções a seguir:");
      Console.WriteLine("1. expenses");
      Console.WriteLine("2. revenues");
      Console.WriteLine("3. Histórico");
      Console.WriteLine("4. Sair");
      Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
      string option = Console.ReadLine()!;

      switch (option)
      {
        case "1":
          Register.RegisterMenu("expense");
          break;
        case "2":
          Register.RegisterMenu("revenue");
          break;
        case "3":
          Historic.HistoricMenu();
          break;
        case "4":
          Console.WriteLine("\nEncerrando programa...");
          return;
        default:
          Console.Clear();
          Console.WriteLine("Digite uma opção válida!");
          break;
      }
    }
  }
}
