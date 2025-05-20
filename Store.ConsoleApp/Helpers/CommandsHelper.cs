using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.ConsoleApp.Helpers;

public static class CommandsHelper {
	internal static void CreateMenu() {
		var grid = new Grid();

		grid.AddColumn(new GridColumn().Alignment(Justify.Center));
		grid.AddColumn(new GridColumn().Alignment(Justify.Left));

		grid.AddRow(["Номер команди", "Операція"]);
		grid.AddRow(["1", "Додати книгу"]);
		grid.AddRow(["2", "Додати журнал"]);
		grid.AddRow(["3", "Показати всі книги"]);
		grid.AddRow(["4", "Показати всі журнали"]);
		grid.AddRow(["5", "Пошук книги за автором"]);
		grid.AddRow(["6", "Пошук журналу за номером"]);
		grid.AddRow(["7", "Вартість 1 номеру журналу"]);
		grid.AddRow(["8", "Купівля книги в кредит"]);
		grid.AddRow(["9", "Купити книгу або журнал"]);
		grid.AddRow(["10", "Переглянути куплене"]);
		grid.AddRow(["0", "Вихід"]);

		var panel = new Panel(grid);
		panel.Header("Меню", Justify.Center);

		AnsiConsole.Write(panel);
	}

	internal static void AddBook(this AppDbContext db) {
		var title = AnsiConsole.Prompt(new TextPrompt<string>("Назва: "));
		var author = AnsiConsole.Prompt(new TextPrompt<string>("Автор: "));
		var topic = AnsiConsole.Prompt(new TextPrompt<string>("Тематика: "));
		var year = AnsiConsole.Prompt(new TextPrompt<int>("Рік: "));
		var publisher = AnsiConsole.Prompt(new TextPrompt<string>("Видавництво: "));
		var language = AnsiConsole.Prompt(new TextPrompt<Languages>("Мова: ")
		                                  .AddChoices([Languages.Ua, Languages.En, Languages.Pl, Languages.Ru, Languages.Fr, Languages.Ge])
										  .DefaultValue(Languages.Ua));
		var pages = AnsiConsole.Prompt(new TextPrompt<int>("Кількість сторінок: "));
		var price = AnsiConsole.Prompt(new TextPrompt<decimal>("Ціна: "));

		db.LiteratureItems.Add(new Book {
			Title = title,
			Author = author,
			Topic = topic,
			Year = year,
			Publisher = publisher,
			Language = language,
			Pages = pages,
			Price = price
		});
		db.SaveChanges();
		AnsiConsole.Write(new Markup($"[bold green]Книгу додано: \"{title}\"[/]" +
		                             $"{Environment.NewLine}{Environment.NewLine}"));
	}

	internal static void AddMagazine(this AppDbContext db) {
		var title = AnsiConsole.Prompt(new TextPrompt<string>("Назва: "));
		var topic = AnsiConsole.Prompt(new TextPrompt<string>("Тематика: "));
		var perYear = AnsiConsole.Prompt(new TextPrompt<int>("Періодичність (випусків на рік): "));
		var number = AnsiConsole.Prompt(new TextPrompt<int>("Номер: "));
		var pages = AnsiConsole.Prompt(new TextPrompt<int>("Кількість сторінок: "));
		var year = AnsiConsole.Prompt(new TextPrompt<int>("Рік: "));
		var language = AnsiConsole.Prompt(new TextPrompt<Languages>("Мова: ")
		                                  .AddChoices([Languages.Ua, Languages.En, Languages.Pl, Languages.Ru, Languages.Fr, Languages.Ge])
		                                  .DefaultValue(Languages.Ua));
		var price = AnsiConsole.Prompt(new TextPrompt<decimal>("Ціна підписки на рік: "));

		db.LiteratureItems.Add(new Magazine {
			Title = title,
			Topic = topic,
			IssuesPerYear = perYear,
			Pages = pages,
			IssueNumber = number,
			Year = year,
			Language = language,
			Price = price
		});

		db.SaveChanges();
		AnsiConsole.Write(new Markup($"[bold green]Журнал додано: \"{title}\"[/]" +
		                             $"{Environment.NewLine}{Environment.NewLine}"));
	}

	internal static void ShowBooks(this AppDbContext db) {
		var books = db.LiteratureItems.OfType<Book>()
		              .OrderBy(b => b.Title)
		              .ToList();

		var table = new Table {
			Title = new TableTitle("Книги")
		};
		table.ShowRowSeparators();

		table.AddColumn(new TableColumn("Id").Centered());
		table.AddColumn(new TableColumn("Найменування").Centered());
		table.AddColumn(new TableColumn("Тематика").Centered());
		table.AddColumn(new TableColumn("Кількість сторінок").Centered());
		table.AddColumn(new TableColumn("Автор").Centered());
		table.AddColumn(new TableColumn("Видавець").Centered());
		table.AddColumn(new TableColumn("Рік").Centered());
		table.AddColumn(new TableColumn("Мова").Centered());
		table.AddColumn(new TableColumn("Ціна").Centered());

		foreach (var b in books)
			table.AddRow(b.Id.ToString(),
			             b.Title!,
			             b.Topic!,
			             b.Pages.ToString(),
			             b.Author!,
			             b.Publisher!,
			             b.Year.ToString(),
			             b.Language.GetLocalized(),
			             b.Price.ToString(CultureInfo.InvariantCulture));

		AnsiConsole.Write(table);
	}

	internal static void ShowMagazines(this AppDbContext db) {
		var magazines = db.LiteratureItems.OfType<Magazine>()
		                  .ToList();

		var table = new Table {
			Title = new TableTitle("Журнали")
		};
		table.ShowRowSeparators();

		table.AddColumn(new TableColumn("Id").Centered());
		table.AddColumn(new TableColumn("Найменування").Centered());
		table.AddColumn(new TableColumn("Тематика").Centered());
		table.AddColumn(new TableColumn("Періодичність").Centered());
		table.AddColumn(new TableColumn("Номер").Centered());
		table.AddColumn(new TableColumn("Кількість сторінок").Centered());
		table.AddColumn(new TableColumn("Рік").Centered());
		table.AddColumn(new TableColumn("Мова").Centered());
		table.AddColumn(new TableColumn("Ціна підписки (рік)").Centered());

		foreach (var m in magazines)
			table.AddRow(m.Id.ToString(),
			             m.Title!,
			             m.Topic!,
			             m.IssuesPerYear.ToString(),
			             m.IssueNumber.ToString(),
			             m.Pages.ToString(),
			             m.Year.ToString(),
			             m.Language.GetLocalized(),
						 m.Price.ToString(CultureInfo.InvariantCulture));

		AnsiConsole.Write(table);
	}

	internal static void FindBooksByAuthor(this AppDbContext db) {
		var author = AnsiConsole.Prompt(new TextPrompt<string>("Введіть ім’я автора: "));

		var found = db.LiteratureItems.OfType<Book>()
		              .Where(b => b.Author != null && b.Author.Contains(author))
		              .ToList();
		if (!found.Any())
			AnsiConsole.Write(new Markup($"[bold red]Книг не знайдено[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
		else {
			var table = new Table {
				Title = new TableTitle("Книги")
			};
			table.ShowRowSeparators();

			table.AddColumn(new TableColumn("Id").Centered());
			table.AddColumn(new TableColumn("Найменування").Centered());
			table.AddColumn(new TableColumn("Автор").Centered());
			table.AddColumn(new TableColumn("Кількість сторінок").Centered());
			table.AddColumn(new TableColumn("Рік").Centered());
			table.AddColumn(new TableColumn("Мова").Centered());
			table.AddColumn(new TableColumn("Ціна").Centered());

			foreach (var b in found)
				table.AddRow(b.Id.ToString(),
				             b.Title!,
				             b.Author!,
				             b.Pages.ToString(),
				             b.Year.ToString(),
				             b.Language.GetLocalized(),
				             b.Price.ToString(CultureInfo.InvariantCulture));

			AnsiConsole.Write(table);
		}
	}

	internal static async void FindMagazineByNumber(this AppDbContext db) {
		var number = AnsiConsole.Prompt(new TextPrompt<int>("Введіть номер журналу: "));

		var found = await db.LiteratureItems.OfType<Magazine>()
		              .Where(m => m.IssueNumber == number)
		              .ToListAsync();

		if (found is not { Count: > 0 })
			AnsiConsole.Write(new Markup($"[bold red]Журнал з номером \"{number}\" не знайдено[/]" +
		                             $"{Environment.NewLine}{Environment.NewLine}"));
		else {
			var table = new Table {
				Title = new TableTitle("Журнали")
			};
			table.ShowRowSeparators();

			table.AddColumn(new TableColumn("Id").Centered());
			table.AddColumn(new TableColumn("Найменування").Centered());
			table.AddColumn(new TableColumn("Періодичність").Centered());
			table.AddColumn(new TableColumn("Номер").Centered());
			table.AddColumn(new TableColumn("Кількість сторінок").Centered());
			table.AddColumn(new TableColumn("Ціна підписки (рік)").Centered());

			foreach (var m in found)
				table.AddRow(m.Id.ToString(),
				             m.Title!,
				             m.IssuesPerYear.ToString(),
				             m.IssueNumber.ToString(),
				             m.Pages.ToString(),
				             m.Price.ToString(CultureInfo.InvariantCulture));

			AnsiConsole.Write(table);
		}
	}

	internal static async void ShowMagazineCostPerIssue(this AppDbContext db) {
		var name = AnsiConsole.Prompt(new TextPrompt<string>("Назва журналу: "));
		var mag = await db.LiteratureItems.OfType<Magazine>()
		            .FirstOrDefaultAsync(m => m.Title != null && m.Title.Contains(name));

		if (mag == null)
			AnsiConsole.Write(new Markup($"[bold red]Журнал що містить назві значення \"{name}\" не знайдено[/]" +
		                             $"{Environment.NewLine}{Environment.NewLine}"));
		else
			AnsiConsole.Write(new Markup($"[bold green]Ціна за 1 номер журналу \"{mag.Title}\": {mag.CalculateCost():0.00} грн.[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
	}

	internal static async void ShowCreditOptionForExpensiveBooks(this AppDbContext db) {
		var expensive = db.LiteratureItems.OfType<Book>()
		                  .Where(b => b.Price > 1000)
		                  .ToList();
		if (!expensive.Any())
			AnsiConsole.Write(new Markup($"[bold red]Книг з ціною понад 1000 грн не знайдено[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
		else {
			var table = new Table {
				Title = new TableTitle("Книги")
			};
			table.ShowRowSeparators();

			table.AddColumn(new TableColumn("Id").Centered());
			table.AddColumn(new TableColumn("Найменування").Centered());
			table.AddColumn(new TableColumn("Ціна в кредит").Centered());
			table.AddColumn(new TableColumn("Термін").Centered());

			foreach (var b in expensive)
				table.AddRow(b.Id.ToString(),
				             b.Title!,
				             $"{b.CalculateCost():0.00} грн.",
				             $"{b.PaymentPeriod} місяців");

			AnsiConsole.Write(table);

			var selectedId = AnsiConsole.Prompt(new TextPrompt<int>("Введіть \"Id\" літератури для купівлі або 0 для виходу в меню: "));
			if (selectedId != 0) {
				var book = expensive.Find(book => book.Id == selectedId);
				if (book != null) {
					var userName = AnsiConsole.Prompt(new TextPrompt<string>("Ім’я покупця: ")
						                                  .DefaultValue("Anonymous"));

					await db.Purchases.AddAsync(new Purchase {
						LiteratureId = book.Id,
						Buyer = userName,
						PurchaseDate = DateTime.Now,
						IsCredit = true
					});

					await db.SaveChangesAsync();

					AnsiConsole.Write(new Markup($"[bold green]Придбано книгу \"{book.Title}\" в кредит на {book.PaymentPeriod} місяців[/]" +
					                             $"{Environment.NewLine}{Environment.NewLine}"));
				}
				else {
					AnsiConsole.Write(new Markup($"[bold red]Книга з Id \"{selectedId}\" не знайдена.[/]" +
					                             $"{Environment.NewLine}{Environment.NewLine}"));
				}
			}
			else {
				AnsiConsole.Write(new Markup($"[bold]Ви вийшли з меню купівлі книги в кредит[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
			}
		}
	}

	internal static async void PurchaseItem(this AppDbContext db) {
		var selectedType = AnsiConsole.Prompt(new TextPrompt<int>("Введіть \"1\" для купівлі книги " +
		                                                          "або \"2\" для купівлі журналу " +
		                                                          "або 0 для виходу в меню: ")
		                                      .AddChoices([0, 1, 2])
		                                      .DefaultValue(0));
		switch (selectedType) {
			case 0:
				AnsiConsole.Write(new Markup($"[bold]Ви вийшли з меню купівлі літератури[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
				return;
			case 1:
				db.ShowBooks();
				break;
			case 2:
				db.ShowMagazines();
				break;
			default:
				AnsiConsole.Write(new Markup($"[bold red]Невідома команда: \"{selectedType}\"[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
				return;
		}

		var literatureType = selectedType == 1 ? "книги" : "журналу";

		var id = AnsiConsole.Prompt(new TextPrompt<int>($"Введіть \"Id\" {literatureType} для купівлі: "));

		if (selectedType == 1) {
			var book = await db.LiteratureItems.OfType<Book>()
			  .FirstOrDefaultAsync(book => book.Id == id);

			if (book == null) {
				AnsiConsole.Write(new Markup($"[bold red]Книга з Id \"{id}\" не знайдена[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
			}
			else {
				var userName = AnsiConsole.Prompt(new TextPrompt<string>("Ім’я покупця: ")
					                                  .DefaultValue("Anonymous"));

				await db.Purchases.AddAsync(new Purchase {
					LiteratureId = book.Id,
					Buyer = userName,
					PurchaseDate = DateTime.Now,
					IsCredit = false,
					Type = LiteratureType.Book
				});

				await db.SaveChangesAsync();

				AnsiConsole.Write(new Markup($"[bold green]Придбано книгу \"{book.Title}\"[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
			}
		}
		else {
			var magazine = await db.LiteratureItems.OfType<Magazine>()
			                   .FirstOrDefaultAsync(book => book.Id == id);

			if (magazine == null) {
				AnsiConsole.Write(new Markup($"[bold red]Журнал з Id \"{id}\" не знайдено[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
			}
			else {
				var userName = AnsiConsole.Prompt(new TextPrompt<string>("Ім’я покупця: ")
					                                  .DefaultValue("Anonymous"));

				await db.Purchases.AddAsync(new Purchase {
					LiteratureId = magazine.Id,
					Buyer = userName,
					PurchaseDate = DateTime.Now,
					IsCredit = false,
					Type = LiteratureType.Magazine
				});

				await db.SaveChangesAsync();

				AnsiConsole.Write(new Markup($"[bold green]Придбано журнал \"{magazine.Title}\"[/]" +
				                             $"{Environment.NewLine}{Environment.NewLine}"));
			}
		}
	}

	internal static async void ViewPurchases(this AppDbContext db) {
		if (!await db.Purchases.AnyAsync()) {
			AnsiConsole.Write(new Markup($"[bold red]Нічого не було придбано[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
			return;
		}

		var buyers = db.Purchases.Select(purchase => purchase.Buyer).Distinct();

		var columns = new List<Text>();
		foreach (var buyer in buyers)
			if (buyer != null)
				columns.Add(new Text($"|{buyer}|"));

		AnsiConsole.Write(new Panel(new Columns(columns))
			                  .Header("Клієнти"));

		var userName = AnsiConsole.Prompt(new TextPrompt<string?>("Введіть ім’я клієнта: "));

		var purchases = db.Purchases.Where(purchase => purchase.Buyer == userName);
		if (!await purchases.AnyAsync()) {
			AnsiConsole.Write(new Markup($"[bold red]Не знайдено даних по клієнту \"{userName}\"[/]" +
			                             $"{Environment.NewLine}{Environment.NewLine}"));
			return;
		}

		AnsiConsole.Clear();

		var table = new Table {
			Title = new TableTitle($"Придбана література клієнта \"{userName}\"")
		};
		table.ShowRowSeparators();

		table.AddColumn(new TableColumn("Id").Centered());
		table.AddColumn(new TableColumn("Тип літератури").Centered());
		table.AddColumn(new TableColumn("Найменування").Centered());
		table.AddColumn(new TableColumn("Мова").Centered());
		table.AddColumn(new TableColumn("Ціна, грн.").Centered());
		table.AddColumn(new TableColumn("В кредит").Centered());
		table.AddColumn(new TableColumn("Дата й час купівлі").Centered());

		foreach (var l in purchases.Include(purchase => purchase.Literature))
			table.AddRow(l.Id.ToString(),
			             l.Type.GetLocalized(),
			             l.Literature.Title!,
			             l.Literature.Language.GetLocalized(),
			             l.Literature.Price.ToString(CultureInfo.InvariantCulture),
			             l.IsCredit.GetLocalized(),
						 l.PurchaseDate.ToString("dd.MM.yyyy HH:mm:ss"));

		AnsiConsole.Write(table);
	}
}