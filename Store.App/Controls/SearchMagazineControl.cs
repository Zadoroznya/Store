using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class SearchMagazineControl : UserControl {
	private readonly AppDbContext _dbContext;

	public SearchMagazineControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
	}

	private async void SearchButton_Click(object sender, EventArgs e) {
		try {
			if (NumberBox.Value <= 0) {
				MessageBox.Show("Поле \"Номер журналу\" не вказано",
				                "Помилка пошуку",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			var magazines = await _dbContext.LiteratureItems.OfType<Magazine>()
			                                .Where(book => book.IssueNumber == (int)NumberBox.Value)
			                                .OrderBy(b => b.Title)
			                                .ToListAsync();

			if (magazines.Count < 0) {
				MessageBox.Show($"Жоден журнал не містить значення \"{NumberBox.Value}\" в полі \"Номер журналу\"",
				                "Помилка пошуку",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			MagazineDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			MagazineDataView.ReadOnly = true;

			MagazineDataView.Columns.Clear();

			MagazineDataView.Columns.Add(nameof(Magazine.Id), "Id");
			MagazineDataView.Columns.Add(nameof(Magazine.Title), "Назва");
			MagazineDataView.Columns.Add(nameof(Magazine.Topic), "Тематика");
			MagazineDataView.Columns.Add(nameof(Magazine.IssuesPerYear), "Періодичність");
			MagazineDataView.Columns.Add(nameof(Magazine.IssueNumber), "Номер");
			MagazineDataView.Columns.Add(nameof(Magazine.Year), "Рік");
			MagazineDataView.Columns.Add(nameof(Magazine.Language), "Мова");
			MagazineDataView.Columns.Add(nameof(Magazine.Pages), "Сторінки");
			MagazineDataView.Columns.Add(nameof(Magazine.Price), "Ціна");

			MagazineDataView.Rows.Clear();

			foreach (var magazine in magazines)
				MagazineDataView.Rows.Add(magazine.Id,
				                          magazine.Title,
				                          magazine.Topic,
				                          magazine.IssuesPerYear,
				                          magazine.IssueNumber,
				                          magazine.Pages,
				                          magazine.Year,
				                          magazine.Language.GetLocalized(),
				                          $"{magazine.Price} грн.");
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}