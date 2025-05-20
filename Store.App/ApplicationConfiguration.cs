namespace Store.App;

internal static class ApplicationConfiguration {
	public static void Initialize() {
		// Додаткові налаштування WinForms
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		// DPI-налаштування (залежно від .NET версії)
		Application.SetHighDpiMode(HighDpiMode.SystemAware);
	}
}