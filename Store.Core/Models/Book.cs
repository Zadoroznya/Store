namespace Store.Core.Models;

public class Book : Literature {
	public string? Author { get; set; }
	public string? Publisher { get; set; }
	public int Year { get; set; }
	public int PaymentPeriod => (int)(Price / 250);

	public override void DisplayInfo() {
		Console.WriteLine($"Книга: {Title} — {Author} ({Year})");
	}

	public override decimal CalculateCost() =>
		Price <= 1000
			? Price
			: Price / PaymentPeriod;
}