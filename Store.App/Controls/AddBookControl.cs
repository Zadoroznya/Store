using System.Globalization;
using System.Text;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class AddBookControl : UserControl {
	private readonly AppDbContext _dbContext;

	public AddBookControl(AppDbContext dbContext) {
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

		if (string.IsNullOrWhiteSpace(AuthorBox.Text))
			errorBuilder.AppendLine("- Автор не вказаний;");

		if (string.IsNullOrWhiteSpace(TopicBox.Text))
			errorBuilder.AppendLine("- Тематика не зазначена;");

		if (string.IsNullOrWhiteSpace(PublisherBox.Text))
			errorBuilder.AppendLine("- Видавництво не вказане;");

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
			_dbContext.LiteratureItems.Add(new Book {
				Title = NameBox.Text,
				Author = AuthorBox.Text,
				Topic = TopicBox.Text,
				Year = int.Parse(YearBox.Value.ToString(CultureInfo.InvariantCulture)),
				Publisher = PublisherBox.Text,
				Language = (Languages)LanguageBox.SelectedIndex,
				Pages = int.Parse(PagesBox.Value.ToString(CultureInfo.InvariantCulture)),
				Price = PriceBox.Value
			});

			if (_dbContext.SaveChanges() > 0) {
				MessageBox.Show($"Збережено книгу \"{NameBox.Text}\"",
				                "Збереження",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Information);

				Clear();
			}
			else {
				MessageBox.Show($"Не вдалося зберегти книгу \"{NameBox.Text}\"",
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
		AuthorBox.Clear();
		TopicBox.Clear();
		PublisherBox.Clear();
		YearBox.Value = 1950;
		LanguageBox.SelectedIndex = 0;
		PagesBox.Value = 0;
		PriceBox.Value = 0;
	}
}