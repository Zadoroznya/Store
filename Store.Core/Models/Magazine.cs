namespace Store.Core.Models;

public class Magazine : Literature {
	public int Year { get; set; }
	public int IssueNumber { get; set; }
	public int IssuesPerYear { get; set; }

	public override void DisplayInfo() {
		Console.WriteLine($"Журнал: {Title}, №{IssueNumber}, {Year}");
	}

	public override decimal CalculateCost() {
		return Price / IssuesPerYear;
	}
}