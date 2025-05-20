using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class MagazineViewerControl : UserControl {
	private readonly AppDbContext _dbContext;

	public MagazineViewerControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();

		LoadMagazine();
	}

	private void UpdateButton_Click(object sender, EventArgs e) {
		LoadMagazine();
	}


	private async void LoadMagazine() {
		try {
			var magazines = await _dbContext.LiteratureItems.OfType<Magazine>()
			                            .OrderBy(b => b.Title)
			                            .ToListAsync();

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
		catch (Exception e) {
			MessageBox.Show($"Виникла помилка:\r\n{e}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}