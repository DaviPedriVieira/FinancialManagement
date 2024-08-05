namespace RastreamentoFinanceiro
{
  internal class Questions
  {
    public static DateOnly GetDate(string complemento)
    {
      while (true)
      {
        Console.WriteLine($"\nDigite a data {complemento}: ");
        string date = Console.ReadLine()!;

        if (DateOnly.TryParseExact(date, "dd/MM/yyyy", out DateOnly parsedDate))
        {
          return parsedDate;
        }
        else
        {
          Console.WriteLine("Data inválida. Tente novamente.");
        }
      }
    }

    public static double GetValue(string complemento)
    {
      while (true)
      {
        Console.WriteLine($"\nDigite o valor {complemento}: ");
        string value = Console.ReadLine()!;

        if (double.TryParse(value, out double parsedValue))
        {
          if (parsedValue <= 0)
          {
            Console.WriteLine("Valor inválido, não é possível por valores negativos ou zero. Tente novamente.");
          }
          else
          {
            parsedValue = complemento == "da expense" ? -parsedValue : parsedValue;
            return parsedValue;
          }
        }
        else
        {
          Console.WriteLine("Valor inválido. Tente novamente.");
        }
      }
    }

    public static string GetDescription(string complemento)
    {
      while (true)
      {
        Console.WriteLine($"\nDigite uma descrição {complemento}: ");
        string description = Console.ReadLine()!.Trim();

        if (!string.IsNullOrWhiteSpace(description))
        {
          return description;
        }
        else
        {
          Console.WriteLine("Descrição não pode ser vazia. Tente novamente.");
        }
      }
    }

    public static string GetCategory(string complemento)
    {
      while (true)
      {
        Console.WriteLine($"\nDigite a categoria {complemento}: ");
        string category = Console.ReadLine()!.Trim();

        if (!string.IsNullOrWhiteSpace(category))
        {
          return category;
        }
        else
        {
          Console.WriteLine("Categoria não pode ser vazia. Tente novamente.");
        }
      }
    }

    public static int GetId(string complemento)
    {
      while (true)
      {
        Console.WriteLine($"Digite o id que deseja {complemento}: ");
        string id = Console.ReadLine()!.Trim() ;

        if (int.TryParse(id, out int parsedId))
        { 
          return parsedId;
        }
        else
        {
          Console.WriteLine("id inválido.");
        }
      }
    }
  }
}
