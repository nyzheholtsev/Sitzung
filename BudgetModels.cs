using System.Xml.Linq;

namespace Sitzung
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} | {Category}: {Amount} грн";
        }
    }

    public static class DataManager
    {
        public static List<Expense> Expenses = new List<Expense>();

        public static List<string> LoadCategories(string fileName)
        {
            var list = new List<string>();

            if (File.Exists(fileName))
            {
                try
                {
                    XDocument doc = XDocument.Load(fileName);
                    list = doc.Descendants("Item")
                              .Select(x => x.Value)
                              .ToList();
                }
                catch (Exception ex)
                {
                    list.Add("Помилка читання файлу!");
                }
            }
            else
            {       
                list.Add("Файл не знайдено");
            }

            return list;
        }

        public static void AddExpense(DateTime date, string category, decimal amount)
        {
            Expenses.Add(new Expense
            {
                Date = date,
                Category = category,
                Amount = amount
            });
        }
    }
}