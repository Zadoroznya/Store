using Microsoft.EntityFrameworkCore;
using Store.Core.Database;
using Store.Core.Enums;
using Store.Core.Models;

namespace Store.App.Controls;

public partial class InfoSellControl : UserControl {
	private readonly AppDbContext _dbContext;

	public InfoSellControl(AppDbContext db) {
		_dbContext = db;
		InitializeComponent();
		LoadUsers();
		InitTable();
	}

	private void InitTable() {
		LiteratureDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		LiteratureDataView.ReadOnly = true;

		LiteratureDataView.Columns.Clear();

		LiteratureDataView.Columns.Add(nameof(Purchase.Id), "Id");
		LiteratureDataView.Columns.Add(nameof(Purchase.PurchaseDate), "Дата/час покупки");
		LiteratureDataView.Columns.Add(nameof(Purchase.Type), "Тип літератури");
		LiteratureDataView.Columns.Add(nameof(Purchase.IsCredit), "В кредит");
		LiteratureDataView.Columns.Add(nameof(Literature.Title), "Назва");
		LiteratureDataView.Columns.Add(nameof(Literature.Topic), "Тематика");
		LiteratureDataView.Columns.Add(nameof(Literature.Language), "Мова");
		LiteratureDataView.Columns.Add(nameof(Literature.Pages), "Сторінки");
		LiteratureDataView.Columns.Add(nameof(Literature.Price), "Ціна");
	}

	private async void LoadUsers() {
		try {
			var users = await _dbContext.Purchases
			                            .Select(purchase => purchase.Buyer)
			                            .Distinct()
			                            .ToListAsync();

			if (!users.Any()) {
				MessageBox.Show("Не знайдено покупців",
				                "Помилка відображення",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				return;
			}

			UserListBox.Items.Clear();
			foreach (var user in users)
				UserListBox.Items.Add(user!);
		}
		catch (Exception e) {
			MessageBox.Show($"Виникла помилка:\r\n{e}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}

	private async void UserListBox_SelectedIndexChanged(object sender, EventArgs e) {
		await ShowDetail();
	}

	private async Task ShowDetail() {
		try {
			var list = await _dbContext.Purchases
			                           .Where(purchase => purchase.Buyer == UserListBox.Text)
			                           .Include(purchase => purchase.Literature)
			                           .ToListAsync();

			LiteratureDataView.Rows.Clear();
			foreach (var item in list)
				LiteratureDataView.Rows.Add(item.Id,
				                            item.PurchaseDate,
				                            item.Type.GetLocalized(),
				                            item.IsCredit.GetLocalized(),
				                            item.Literature.Title,
				                            item.Literature.Topic,
				                            item.Literature.Language.GetLocalized(),
				                            item.Literature.Pages,
				                            item.Literature.Price);
		}
		catch (Exception exception) {
			MessageBox.Show($"Виникла помилка:\r\n{exception}",
			                "Помилка відображення",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}

	private async void UpdateButton_Click(object sender, EventArgs e) {
		 LoadUsers();
		await ShowDetail();
	}
}