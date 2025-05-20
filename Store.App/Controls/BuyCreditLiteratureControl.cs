using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class BuyCreditLiteratureControl : UserControl {
	private readonly AppDbContext _dbContext;

	public BuyCreditLiteratureControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
		InitTable();
		LoadBooks();
	}

	private void InitTable() {
		LiteratureBookView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		LiteratureBookView.ReadOnly = true;

		LiteratureBookView.Columns.Clear();

		LiteratureBookView.Columns.Add(nameof(Book.Id), "Id");
		LiteratureBookView.Columns.Add(nameof(Book.Title), "Назва");
		LiteratureBookView.Columns.Add(nameof(Book.Author), "Автор");
		LiteratureBookView.Columns.Add(nameof(Book.Language), "Мова");
		LiteratureBookView.Columns.Add(nameof(Book.Price), "Ціна в кредит");
		LiteratureBookView.Columns.Add(nameof(Book.PaymentPeriod), "Термін");
	}

	private async void LoadBooks() {
		var books = await _dbContext.LiteratureItems.OfType<Book>()
		                            .Where(book => book.Price > 1000)
		                            .OrderBy(b => b.Title)
		                            .ToListAsync();

		LiteratureBookView.Rows.Clear();

		foreach (var book in books)
			LiteratureBookView.Rows.Add(book.Id,
			                            book.Title,
			                            book.Author,
			                            book.Language.GetLocalized(),
			                            $"{book.CalculateCost():F2} грн.",
			                            book.PaymentPeriod);
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
							IsCredit = true,
							Type = LiteratureType.Book
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
}