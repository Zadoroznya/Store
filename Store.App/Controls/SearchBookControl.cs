using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class SearchBookControl : UserControl {
	private readonly AppDbContext _dbContext;

	public SearchBookControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
	}

	private async void SearchButton_Click(object sender, EventArgs e) {
		try {
			if (string.IsNullOrWhiteSpace(SearchBox.Text)) {
				MessageBox.Show("Поле \"Автор\" пусте",
				                "Помилка пошуку",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			var books = await _dbContext.LiteratureItems.OfType<Book>()
			                            .Where(book => book.Author.Contains(SearchBox.Text))
			                            .OrderBy(b => b.Title)
			                            .ToListAsync();

			if (books.Count < 0) {
				MessageBox.Show($"Жодна книга не містить значення \"{SearchBox.Text}\" в полі \"Автор\"",
				                "Помилка пошуку",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			BookDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			BookDataView.ReadOnly = true;

			BookDataView.Columns.Clear();

			BookDataView.Columns.Add(nameof(Book.Id), "Id");
			BookDataView.Columns.Add(nameof(Book.Title), "Назва");
			BookDataView.Columns.Add(nameof(Book.Author), "Автор");
			BookDataView.Columns.Add(nameof(Book.Topic), "Тематика");
			BookDataView.Columns.Add(nameof(Book.Year), "Рік");
			BookDataView.Columns.Add(nameof(Book.Publisher), "Видавництво");
			BookDataView.Columns.Add(nameof(Book.Language), "Мова");
			BookDataView.Columns.Add(nameof(Book.Pages), "Сторінки");
			BookDataView.Columns.Add(nameof(Book.Price), "Ціна");

			BookDataView.Rows.Clear();

			foreach (var book in books)
				BookDataView.Rows.Add(book.Id,
				                      book.Title,
				                      book.Author,
				                      book.Topic,
				                      book.Year,
				                      book.Publisher,
				                      book.Language.GetLocalized(),
				                      book.Pages,
				                      $"{book.Price} грн.");
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}