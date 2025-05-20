using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class BookViewerControl : UserControl {
	private readonly AppDbContext _dbContext;

	public BookViewerControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();

		LoadBooks();
	}

	private void UpdateButton_Click(object sender, EventArgs e) {
		LoadBooks();
	}


	private async void LoadBooks() {
		try {
			var books = await _dbContext.LiteratureItems.OfType<Book>()
			                      .OrderBy(b => b.Title)
			                      .ToListAsync();
			
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
		catch (Exception e) {
			MessageBox.Show($"Виникла помилка:\r\n{e}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}