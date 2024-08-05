namespace RastreamentoFinanceiro.Classes
{
  internal class Expenses_and_Revenues
  {
    private int Id { get; set; }
    private DateOnly Date { get; set; }
    private double Value { get; set; }
    private string Description { get; set; } = string.Empty;
    private string Category { get; set; } = string.Empty;

    public static List<Expenses_and_Revenues> expenses = new List<Expenses_and_Revenues>();
    public static List<Expenses_and_Revenues> revenues = new List<Expenses_and_Revenues>();

    public Expenses_and_Revenues(int id, DateOnly date, double value, string description, string category)
    {
      Id = id;
      Date = date;
      Value = value;
      Description = description;
      Category = category;
    }

    public int GetId() => Id;
    public DateOnly GetDate() => Date;
    public double GetValue() => Value;
    public string GetDescription() => Description;
    public string GetCategory() => Category;

    public void SetId(int id) => Id = id;
    public void SetDate(DateOnly date) => Date = date;
    public void SetValue(double value) => Value = value;
    public void SetDescription(string description) => Description = description;
    public void SetCategory(string category) => Category = category;


    public static void Addexpense(Expenses_and_Revenues expense)
    {
      expenses.Add(expense);
    }

    public static void Addrevenue(Expenses_and_Revenues revenue)
    {
      revenues.Add(revenue);
    }

    public static void PrintItem(Expenses_and_Revenues item)
    {
      Console.WriteLine($"id: {item.Id}, data: {item.Date}, valor: {item.Value}; descrição: {item.GetDescription()}, categoria: {item.GetCategory()}");
    }
  }
}
