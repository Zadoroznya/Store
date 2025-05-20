using Store.App.Controls;
using Store.Core.Database;

namespace Store.App;

public partial class Store : Form {
	private readonly Dictionary<string, UserControl?> _controlsCache = new();
	private readonly AppDbContext _db = new();

	public Store() {
		InitializeComponent();
		InitializeList();
		_db.Initialize();
	}

	private void InitializeList() {
		MainTreeView.Nodes.Clear();

		var itemBook = new TreeNode("Додати книгу") {
			Name = Constants.AddBookKey
		};
		var itemMagazine = new TreeNode("Додати журнал") {
			Name = Constants.AddMagazineKey
		};

		var addGroup = new TreeNode("Додавання") {
			Nodes = { itemBook, itemMagazine }
		};

		var itemShowBook = new TreeNode("Показати всі книги") {
			Name = Constants.ViewBookKey
		};
		var itemShowMagazine = new TreeNode("Показати всі журнали") {
			Name = Constants.ViewMagazineKey
		};

		var showGroup = new TreeNode("Перегляд") {
			Nodes = { itemShowBook, itemShowMagazine }
		};

		var searchBookByAuthor = new TreeNode("Пошук книги за автором") {
			Name = Constants.SearchBookKey
		};

		var searchMagazineByNumber = new TreeNode("Пошук журналу за номером") {
			Name = Constants.SearchMagazineKey
		};

		var searchGroup = new TreeNode("Пошук") {
			Nodes = { searchBookByAuthor, searchMagazineByNumber }
		};

		var infoBook = new TreeNode("Вартість одного номеру журналу") {
			Name = Constants.InfoMagazineKey
		};

		var infoSell = new TreeNode("Переглянути куплене") {
			Name = Constants.InfoSellKey
		};

		var infoGroup = new TreeNode("Інформація") {
			Nodes = { infoBook, infoSell }
		};

		var buyLiterature = new TreeNode("Купити книгу або журнал") {
			Name = Constants.BuyLiteratureKey
		};

		var buyCreditLiterature = new TreeNode("Купівля книги в кредит") {
			Name = Constants.BuyCreditLiteratureKey
		};

		var buyGroup = new TreeNode("Купівля") {
			Nodes = { buyLiterature, buyCreditLiterature }
		};

		MainTreeView.Nodes.AddRange([addGroup, showGroup, searchGroup, infoGroup, buyGroup]);
	}

	private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
		if (MainTreeView.SelectedNode == null)
			return;

		var key = MainTreeView.SelectedNode.Name;
		if (!string.IsNullOrWhiteSpace(key))
			LoadUserControl(key);
	}

	private void LoadUserControl(string key) {
		if (!_controlsCache.TryGetValue(key, out var control)) {
			control = key switch {
				Constants.AddBookKey => new AddBookControl(_db),
				Constants.AddMagazineKey => new AddMagazineControl(_db),
				Constants.ViewBookKey => new BookViewerControl(_db),
				Constants.ViewMagazineKey => new MagazineViewerControl(_db),
				Constants.SearchBookKey => new SearchBookControl(_db),
				Constants.SearchMagazineKey => new SearchMagazineControl(_db),
				Constants.InfoMagazineKey => new InfoPriceMagazineControl(_db),
				Constants.InfoSellKey => new InfoSellControl(_db),
				Constants.BuyLiteratureKey => new BuyLiteratureControl(_db),
				Constants.BuyCreditLiteratureKey => new BuyCreditLiteratureControl(_db),
				_ => null
			};

			if (control == null) {
				MessageBox.Show("Не знайшло необхідний компонент для відображення",
				                "Критична помилка!",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
				return;
			}

			_controlsCache[key] = control;
		}

		if (control != null) {
			MainPanel.Controls.Clear();
			control.Dock = DockStyle.Fill;
			MainPanel.Controls.Add(control);
		}
		else {
			MessageBox.Show("Не знайшло необхідний компонент для відображення",
			                "Критична помилка!",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Error);
		}
	}
}