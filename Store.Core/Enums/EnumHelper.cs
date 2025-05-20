namespace Store.Core.Enums;

public static class EnumHelper {
	public static string GetLocalized(this Languages lang) {
		return lang switch {
			Languages.Ua => "Українська",
			Languages.En => "Англійська",
			Languages.Pl => "Польська",
			Languages.Ru => "Російська",
			Languages.Fr => "Французька",
			Languages.Ge => "Німецька",
			_ => "Невідома мова"
		};
	}

	public static string GetLocalized(this LiteratureType lang) {
		return lang switch {
			LiteratureType.Book => "Книга",
			LiteratureType.Magazine => "Журнал",
			_ => "Невідомий тип"
		};
	}

	public static string GetLocalized(this bool state) =>
		state
			? "Так"
			: "Ні";
}