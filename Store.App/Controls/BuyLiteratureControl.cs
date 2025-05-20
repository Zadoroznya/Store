using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class BuyLiteratureControl : UserControl {
	private readonly AppDbContext _dbContext;
	private LiteratureType _type;

	public BuyLiteratureControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
		LoadData(LiteratureType.Book);
	}

	private async void LoadData(LiteratureType literatureType) {
		_type = literatureType;

		if (literatureType == LiteratureType.Book) {
			var books = await _dbContext.LiteratureItems.OfType<Book>()
			                            .OrderBy(b => b.Title)
			                            .ToListAsync();
			LiteratureBookView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			LiteratureBookView.ReadOnly = true;

			LiteratureBookView.Columns.Clear();

			LiteratureBookView.Columns.Add(nameof(Book.Id), "Id");
			LiteratureBookView.Columns.Add(nameof(Book.Title), "Назва");
			LiteratureBookView.Columns.Add(nameof(Book.Author), "Автор");
			LiteratureBookView.Columns.Add(nameof(Book.Topic), "Тематика");
			LiteratureBookView.Columns.Add(nameof(Book.Year), "Рік");
			LiteratureBookView.Columns.Add(nameof(Book.Publisher), "Видавництво");
			LiteratureBookView.Columns.Add(nameof(Book.Language), "Мова");
			LiteratureBookView.Columns.Add(nameof(Book.Pages), "Сторінки");
			LiteratureBookView.Columns.Add(nameof(Book.Price), "Ціна");

			LiteratureBookView.Rows.Clear();

			foreach (var book in books)
				LiteratureBookView.Rows.Add(book.Id,
				                            book.Title,
				                            book.Author,
				                            book.Topic,
				                            book.Year,
				                            book.Publisher,
				                            book.Language.GetLocalized(),
				                            book.Pages,
				                            $"{book.Price} грн.");
		}
		else {
			var magazines = await _dbContext.LiteratureItems.OfType<Magazine>()
			                                .OrderBy(b => b.Title)
			                                .ToListAsync();

			LiteratureBookView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			LiteratureBookView.ReadOnly = true;

			LiteratureBookView.Columns.Clear();

			LiteratureBookView.Columns.Add(nameof(Magazine.Id), "Id");
			LiteratureBookView.Columns.Add(nameof(Magazine.Title), "Назва");
			LiteratureBookView.Columns.Add(nameof(Magazine.Topic), "Тематика");
			LiteratureBookView.Columns.Add(nameof(Magazine.IssuesPerYear), "Періодичність");
			LiteratureBookView.Columns.Add(nameof(Magazine.IssueNumber), "Номер");
			LiteratureBookView.Columns.Add(nameof(Magazine.Year), "Рік");
			LiteratureBookView.Columns.Add(nameof(Magazine.Language), "Мова");
			LiteratureBookView.Columns.Add(nameof(Magazine.Pages), "Сторінки");
			LiteratureBookView.Columns.Add(nameof(Magazine.Price), "Ціна");

			LiteratureBookView.Rows.Clear();

			foreach (var magazine in magazines)
				LiteratureBookView.Rows.Add(magazine.Id,
				                            magazine.Title,
				                            magazine.Topic,
				                            magazine.IssuesPerYear,
				                            magazine.IssueNumber,
				                            magazine.Pages,
				                            magazine.Year,
				                            magazine.Language.GetLocalized(),
				                            $"{magazine.Price} грн.");
		}
	}

	private async void BuyButton_Click(object sender, EventArgs e) {
		try {
			if (string.IsNullOrWhiteSpace(UsernameBox.Text)) {
				MessageBox.Show("Поле імені покупця пусте",
				                "Помилка купівлі",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			if (LiteratureBookView.SelectedRows.Count > 0) {
				var item = LiteratureBookView.SelectedRows[0];
				var value = item.Cells[nameof(Literature.Id)]
				                .Value.ToString();
				if (string.IsNullOrWhiteSpace(value)) {
					MessageBox.Show("Виникла помилка в полі під час вибору даних",
					                "Помилка купівлі",
					                MessageBoxButtons.OK,
					                MessageBoxIcon.Error);
				}
				else {
					var id = int.Parse(value);
					var literature = await _dbContext.LiteratureItems.FindAsync(id);
					if (literature == null) {
						MessageBox.Show("Виникла помилка під очас тотримання інформації про товар",
						                "Помилка купівлі",
						                MessageBoxButtons.OK,
						                MessageBoxIcon.Error);
					}
					else {
						await _dbContext.Purchases.AddAsync(new Purchase {
							LiteratureId = literature.Id,
							Buyer = UsernameBox.Text,
							PurchaseDate = DateTime.Now,
							IsCredit = false,
							Type = _type
						});

						await _dbContext.SaveChangesAsync();

						MessageBox.Show($"Придбано літературу \"{literature.Title}\" " +
						                $"покупцем \"{UsernameBox.Text}\" " +
						                $"за {literature.Price} грн.",
						                "Помилка купівлі",
						                MessageBoxButtons.OK,
						                MessageBoxIcon.Information);
					}
				}
			}
			else {
				MessageBox.Show("Жодну літературу не вибрано",
				                "Помилка купівлі",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
			}
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}

	private void RadioBookButton_CheckedChanged(object sender, EventArgs e) {
		LoadData(LiteratureType.Book);
	}

	private void RadioMagazineButton_CheckedChanged(object sender, EventArgs e) {
		LoadData(LiteratureType.Magazine);
	}
}