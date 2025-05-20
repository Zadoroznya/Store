using System.Text;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class AddMagazineControl : UserControl {
	private readonly AppDbContext _dbContext;

	public AddMagazineControl(AppDbContext dbContext) {
		_dbContext = dbContext;
		InitializeComponent();

		foreach (Languages item in Enum.GetValues(typeof(Languages)))
			LanguageBox.Items.Add(item.GetLocalized());

		LanguageBox.SelectedIndex = 0;
	}

	private void SaveButton_Click(object sender, EventArgs e) {
		var errorBuilder = new StringBuilder();

		if (string.IsNullOrWhiteSpace(NameBox.Text))
			errorBuilder.AppendLine("- Назва не заповнена;");

		if (string.IsNullOrWhiteSpace(TopicBox.Text))
			errorBuilder.AppendLine("- Тематика не зазначена;");

		if (PerYearBox.Value <= 0)
			errorBuilder.AppendLine("- Періодичність не вказана;");

		if (NumberBox.Value <= 0)
			errorBuilder.AppendLine("- Номер журналу не визначений;");

		if (PagesBox.Value <= 0)
			errorBuilder.AppendLine("- Кількість сторінок не написана;");

		if (PriceBox.Value <= 0)
			errorBuilder.AppendLine("- Ціна не виставлена;");

		if (errorBuilder.Length > 0) {
			MessageBox.Show($"Знайдено наступні помилки:\r\n{errorBuilder}",
			                "Збереження",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Warning);
			return;
		}

		try {
			_dbContext.LiteratureItems.Add(new Magazine {
				Title = NameBox.Text,
				Topic = TopicBox.Text,
				IssuesPerYear = (int)PerYearBox.Value,
				Pages = (int)PagesBox.Value,
				IssueNumber = (int)NumberBox.Value,
				Year = (int)YearBox.Value,
				Language = (Languages)LanguageBox.SelectedIndex,
				Price = PriceBox.Value
			});

			if (_dbContext.SaveChanges() > 0) {
				MessageBox.Show($"Збережено журнал \"{NameBox.Text}\"",
				                "Збереження",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Information);

				Clear();
			}
			else {
				MessageBox.Show($"Не вдалося зберегти журнал \"{NameBox.Text}\"",
				                "Збереження",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Information);
			}
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка збереження",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}

	private void ClearButton_Click(object sender, EventArgs e) => Clear();

	private void Clear() {
		NameBox.Clear();
		TopicBox.Clear();
		PerYearBox.Value = 0;
		NumberBox.Value = 0;
		YearBox.Value = 1950;
		LanguageBox.SelectedIndex = 0;
		PagesBox.Value = 0;
		PriceBox.Value = 0;
	}
}