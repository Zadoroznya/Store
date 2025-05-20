using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class InfoPriceMagazineControl : UserControl {
	private readonly AppDbContext _dbContext;

	public InfoPriceMagazineControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
	}

	private async void SearchButton_Click(object sender, EventArgs e) {
		try {
			if (string.IsNullOrWhiteSpace(SearchBox.Text)) {
				MessageBox.Show("Нічого не введено в \"Назва журналу\"",
				                "Пошук",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			var mag = await _dbContext.LiteratureItems.OfType<Magazine>()
			                          .FirstOrDefaultAsync(m => m.Title != null && m.Title.Contains(SearchBox.Text));

			if (mag == null)
				MessageBox.Show($"Журнал що містить назві значення \"{SearchBox.Text}\" не знайдено",
				                "Пошук",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
			else
				MessageBox.Show($"Ціна за 1 номер журналу \"{mag.Title}\": {mag.CalculateCost():0.00} грн.",
				                "Пошук",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Information);
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}