using System.Text;
using Spectre.Console;
using Store.ConsoleApp.Helpers;
using Store.Core.Database;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

await using var db = new AppDbContext();
db.Initialize();

while (true) {
	CommandsHelper.CreateMenu();

	var input = AnsiConsole.Prompt(new TextPrompt<int>("Вибір: "));

	Console.Clear();

	switch (input) {
		case 1:
			db.AddBook();
			break;
		case 2:
			db.AddMagazine();
			break;
		case 3:
			db.ShowBooks();
			break;
		case 4:
			db.ShowMagazines();
			break;
		case 5:
			db.FindBooksByAuthor();
			break;
		case 6:
			db.FindMagazineByNumber();
			break;
		case 7:
			db.ShowMagazineCostPerIssue();
			break;
		case 8:
			db.ShowCreditOptionForExpensiveBooks();
			break;
		case 9:
			db.PurchaseItem();
			break;
		case 10:
			db.ViewPurchases();
			break;
		case 0: return;
		default:
			AnsiConsole.Write(new Markup($"[bold red]Невірний вибір: \"{input}\"[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
			break;
	}
}